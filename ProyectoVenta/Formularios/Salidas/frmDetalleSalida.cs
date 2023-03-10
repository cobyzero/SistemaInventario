using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using ProyectoVenta.Data;
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


namespace ProyectoVenta.Formularios.Salidas
{
    public partial class frmDetalleSalida : Form
    {
        public frmDetalleSalida()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".:Suchen:.";
                label2.Text = "Neue Suchen";
                label26.Text = "Antragsnummer";
                label4.Text = "Datum";
                label3.Text = "Benutzer";
                btnsalir.Text = "Beendet";
                btnborrar.Text = "Reinigen";
                label5.Text = "Technischer Code";
                label10.Text = "Name des Technikers";
                label7.Text = "Produktliste";
                Codigo.HeaderText = "Code";
                Descripcion.HeaderText = "Beschreibung";
                Categoria.HeaderText = "Lange";
                Almacen.HeaderText = "Lager";
                Cantidad.HeaderText = "Menge";
                btndescargarpdf.Text = "herunterladen PDF";
                lbltextototal.Text = "Gesamt:";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalleSalida_Load(object sender, EventArgs e)
        {
            lblnrodocumento.Text = "";
            txtnumerodocumento.Focus();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (txtnumerodocumento.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Salidum obj = SalidaLogica.Instancia.Obtener(txtnumerodocumento.Text);

            if (obj != null)
            {
                lblnrodocumento.Text = obj.NumeroDocumento;
                txtfecha.Text = obj.FechaRegistro.ToString();
                txtusuario.Text = obj.UsuarioRegistro;
                txtdoccliente.Text = obj.DocumentoCliente;
                txtnomcliente.Text = obj.NombreCliente;

                List<Salidum> olista = SalidaLogica.Instancia.ListarDetalle(obj.IdSalida);
                dgvdata.Rows.Clear();

                foreach (Salidum de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.CodigoProducto, de.DescripcionProducto, de.LongitudProducto, de.AlmacenProducto, de.CantidadProductos });
                }

                
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnumerodocumento.Focus();
            }
        }

        private void chkocultarprecios_CheckedChanged(object sender, EventArgs e)
        {
            
                lbltextototal.Visible = false; 
        }

        private void btndescargarpdf_Click(object sender, EventArgs e)
        {

            if (lblnrodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = string.Empty;
             
            Texto_Html = Properties.Resources.PlantillaSalidaSinPrecio.ToString();

            Data.Dato odatos = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.Ruc);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@numerodocumento", lblnrodocumento.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnomcliente.Text);
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
            savefile.FileName = string.Format("Salida_{0}.pdf", lblnrodocumento.Text);
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
            txtdoccliente.Text = "";
            txtnomcliente.Text = "";
            dgvdata.Rows.Clear();  
            txtnumerodocumento.Focus();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

    
    }
}
