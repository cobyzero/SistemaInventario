using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVenta.Herrarmientas;
using ClosedXML.Excel;

namespace ProyectoVenta.Formularios.Entradas
{
    public partial class frmListarEntradas : Form
    {
        int total = 0;
        public frmListarEntradas()
        {
            InitializeComponent();
            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".: Einträge auflisten :.";
                label2.Text = "Einträge auflisten";
                btnsalir.Text = "hinausgehen";
                label4.Text = "Startdatum";
                label3.Text = "Endtermin";
                btnbuscar.Text = "Suche";
                btnexportar.Text = "Excel herunterladen";
                label12.Text = "zu suchen:";
                FechaRegistro.HeaderText = "Registrierungsdatum";
                NroDocumento.HeaderText = "Dokumentnummer";
                UsuarioRegistro.HeaderText = "Benutzerdatensatz";
                Proveedor.HeaderText = "Anbieter";
                CodigoProducto.HeaderText = "Produktcode";
                DescripcionProducto.HeaderText = "Produktbeschreibung";
                LongitudProducto.HeaderText = "Produktlänge";
                AlmacenProducto.HeaderText = "Lagerprodukt";
                Cantidad.HeaderText = "Menge";
                label5.Text = "gesamt:";


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarEntradas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            total = 0;
            dgvdata.Rows.Clear();

            DateTime dt1 = Convert.ToDateTime(txtfechainicio.Value.ToString("dd/MM/yyyy"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin.Value.ToString("dd/MM/yyyy"));
            List<VistaEntradas> lista = EntradaLogica.Instancia.Resumen(dt1, dt2);

            foreach (VistaEntradas vr in lista)
            {

                dgvdata.Rows.Add(new object[] {
                    vr.FechaRegistro,
                    vr.NumeroDocumento,
                    vr.UsuarioRegistro,
                    vr.NombreProveedor, 
                    vr.CodigoProducto,
                    vr.DescripcionProducto,
                    vr.CategoriaProducto,
                    vr.AlmacenProducto, 
                    vr.Cantidad, 
                });

                total += int.Parse(vr.Cantidad);
            }

            this.label6.Text = total.ToString();
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata.Columns)
                    dt.Columns.Add(column.HeaderText, typeof(string));

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    dt.Rows.Add(new object[] {
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        row.Cells[7].Value.ToString(),
                        row.Cells[8].Value.ToString(),

                    });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Resumen_Entradas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }
    }
}
