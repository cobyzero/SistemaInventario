using ProyectoVenta.Herrarmientas;
using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        private static int _id = 0;
        private static int _indice = 0;

        public frmClientes()
        {
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".: Technisch :.";
                label2.Text = "Technisch";
                btnsalir.Text = "hinausgehen";
                label6.Text = "technische Details".ToUpper();
                label9.Text = "Dokumentnummer";
                label3.Text = "vollständiger Name";
                btnguardar.Text = "halten";
                btneliminar.Text = "beseitigen";
                btnlimpiar.Text = "sauber";
                label7.Text = "Liste der Techniker".ToUpper();
                label12.Text = "zu suchen";
                NumeroDocumento.HeaderText = "Dokumentnummer";
                NombreCompleto.HeaderText = "vollständiger Name";

            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            List<Data.Cliente> lista = ClienteLogica.Instancia.Listar();

            foreach (Data.Cliente pr in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    pr.IdCliente,
                    "",
                    pr.NumeroDocumento,
                    pr.NombreCompleto
                });
            }
            Limpiar();

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

        private void Limpiar(bool vista = true)
        {
            txtnumero.BackColor = Color.White;
            txtnombre.BackColor = Color.White;
            if (vista)
            {
                if (dgvdata.Rows.Count > 0)
                {
                    dgvdata.Rows[_indice].DefaultCellStyle.BackColor = Color.White;
                }
            }
            
            _id = 0;
            _indice = 0;
            txtnumero.Text = "";
            txtnombre.Text = "";
            lblresultado.Text = "";
            txtnumero.Focus();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check16.Width;
                var h = Properties.Resources.check16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
                {
                    dgvdata.Rows[_indice].DefaultCellStyle.BackColor = Color.White;

                    _id = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                    _indice = index;
                    txtnumero.Text = dgvdata.Rows[index].Cells["NumeroDocumento"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[index].Cells["NombreCompleto"].Value.ToString();

                    txtnumero.BackColor = Color.LemonChiffon;
                    txtnombre.BackColor = Color.LemonChiffon;
                    dgvdata.Rows[index].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private async void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtnumero.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el numero de documento";
                lblresultado.ForeColor = Color.Red;
                return;
            }
            if (txtnombre.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el nombre completo";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            Data.Cliente obj = new Data.Cliente(){ IdCliente = _id, NumeroDocumento = txtnumero.Text, NombreCompleto = txtnombre.Text};

            int existe = ClienteLogica.Instancia.Existe(obj.NumeroDocumento, _id, out mensaje);
            if (existe > 0)
            {
                lblresultado.Text = mensaje;
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (_id == 0)
            {
                int idgenerado = await ClienteLogica.Instancia.Guardar(obj);
                if (idgenerado > 0)
                {
                    Limpiar();
                    dgvdata.Rows.Add(new object[] { idgenerado, "", obj.NumeroDocumento, obj.NombreCompleto});
                    lblresultado.Text = "Registro Correcto";
                    lblresultado.ForeColor = Color.Green;
                }
                else
                {
                    lblresultado.Text = "No se pudo registrar el tecnico";
                    lblresultado.ForeColor = Color.Red;
                }
            }
            else
            {
                
                if (await ClienteLogica.Instancia.Editar(obj))
                {
                    dgvdata.Rows[_indice].Cells["NumeroDocumento"].Value = obj.NumeroDocumento;
                    dgvdata.Rows[_indice].Cells["NombreCompleto"].Value = obj.NombreCompleto;
                    Limpiar();
                    lblresultado.Text = "Modificación Correcta";
                    lblresultado.ForeColor = Color.Green;
                }
                else
                {
                    lblresultado.Text = "No se pudo editar el tecnico";
                    lblresultado.ForeColor = Color.Red;
                }

            }
        }

        private async void btneliminar_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    if (await ClienteLogica.Instancia.Eliminar(_id))
                    {
                        dgvdata.Rows.RemoveAt(_indice);
                        Limpiar(false);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar el tecnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tecnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
            dgvdata.ClearSelection();
        }
    }
}
