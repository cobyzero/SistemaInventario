using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios.Entradas
{
    public partial class frmDetalleEntradas : Form
    {
        public frmDetalleEntradas()
        {
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".: Sucheingabe :.";
                label2.Text = "Sucheingabe";
                btnsalir.Text = "hinausgehen";
                label26.Text = "Dokumentnummer";
                btnbuscar.Text = "Suche";
                btnborrar.Text = "sauber";
                label4.Text = "Datum";
                label3.Text = "Benutzer";
                label5.Text = "Lieferantendokument";
                label10.Text = "Anbietername";
                label7.Text = "Produktliste".ToUpper();
               
                Cantidad.HeaderText = "Menge";
                btndescargarpdf.Text = "PDF Herunterladen";

            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDetalleEntrada_Load(object sender, EventArgs e)
        {
            lblnrodocumento.Text = "";
            txtnumerodocumento.Focus();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtnumerodocumento.Text.Trim() == "") {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Data.Entradum obj = EntradaLogica.Instancia.Obtener(txtnumerodocumento.Text);

            if (obj != null)
            {
                lblnrodocumento.Text = obj.NumeroDocumento;
                txtfecha.Text = obj.FechaRegistro.ToString();
                txtusuario.Text = obj.UsuarioRegistro;
                txtdocumentoproveedor.Text = obj.DocumentoProveedor;
                txtnombreproveedor.Text = obj.NombreProveedor;

                List<DetalleEntrada> olista = EntradaLogica.Instancia.ListarDetalle(obj.NumeroDocumento);
                dgvdata.Rows.Clear();
                foreach(DetalleEntrada de in olista) {
                    dgvdata.Rows.Add(new object[] {de.CodigoProducto,de.DescripcionProducto,de.CategoriaProducto,de.AlmacenProducto,de.Cantidad });
                }

                
            }
            else {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnumerodocumento.Focus();
            }
        }

    

        private void btndescargarpdf_Click(object sender, EventArgs e)
        {
            if (lblnrodocumento.Text == "") {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = string.Empty;
            
                Texto_Html = Properties.Resources.PlantillaEntrada.ToString();
             

            Data.Dato odatos = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.Ruc);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@numerodocumento", lblnrodocumento.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocumentoproveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Codigo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Longitud"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
 
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas); 


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Entrada_{0}.pdf", lblnrodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                      
                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void limpiar() {
            txtnumerodocumento.Text = "";
            lblnrodocumento.Text = "";
            txtfecha.Text = "";
            txtusuario.Text = "";
            txtdocumentoproveedor.Text = "";
            txtnombreproveedor.Text = "";
            dgvdata.Rows.Clear();
           
             
            txtnumerodocumento.Focus();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

     
    }
}
