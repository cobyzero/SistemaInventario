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

namespace ProyectoVenta.Formularios.Pedidos
{
    public partial class frmDetallePedidos : Form
    {
        double campoDeDispocicion = 0;
        double total = 0;
        public frmDetallePedidos()
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
                //label4.Text = "Datum";
                //label3.Text = "Benutzer";
                //label5.Text = "Lieferantendokument";
                //label10.Text = "Anbietername";
                //label7.Text = "Produktliste".ToUpper();
                //Codigo.HeaderText = "Code";
                //Descripcion.HeaderText = "Beschreibung";
                //Categoria.HeaderText = "Länge";
                //Almacen.HeaderText = "speichern";
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
            if (txtnumerodocumento.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dgvdata.Rows.Clear();
            List<Data.Pedido> olista = PedidoLogica.Instancia.ListarDetalle(txtnumerodocumento.Text);
            lblnrodocumento.Text = txtnumerodocumento.Text;


            if (olista.Count() > 0)
            {

                campoDeDispocicion = (double)olista[0].Presupuesto;

                foreach (Data.Pedido de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.FechaRegistro, de.NumeroDocumento, de.CodigoProducto, de.DescripcionProducto, de.Tecnico, de.Cantidad, de.Precio, de.SubTotal });

                    campoDeDispocicion -= de.SubTotal;
                    total += de.SubTotal;
                }

                label4.Text = campoDeDispocicion.ToString();
                label5.Text = total.ToString();
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnumerodocumento.Focus();
            }
        }



        private void btndescargarpdf_Click(object sender, EventArgs e)
        {
            if (lblnrodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = string.Empty;

            Texto_Html = Properties.Resources.PlantillaPedidos.ToString();


            Data.Dato odatos = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.Ruc);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);
            Texto_Html = Texto_Html.Replace("@numerodocumento", lblnrodocumento.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["FechaRegistro"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CodigoProducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["DescripcionProducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Tecnico"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Pedido_{0}.pdf", lblnrodocumento.Text);
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

        private void limpiar()
        {
            txtnumerodocumento.Text = "";
            lblnrodocumento.Text = "";
            dgvdata.Rows.Clear();
            campoDeDispocicion = 0;
            label4.Text = campoDeDispocicion.ToString();
            txtnumerodocumento.Focus();
            total = 0;
            label5.Text = total.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar();

        }


    }
}
