using NPOI.SS.Formula.Functions;
using ProyectoVenta.Data;
using ProyectoVenta.Logica;
using ProyectoVenta.Modales;
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

namespace ProyectoVenta.Formularios.Pedidos
{
    public partial class frmRegistrarPedidos : Form
    {
        private static int _idproducto = 0;
        private static string _NombreUsuario = "";
        private static int count = 0;
        decimal total = 0;
        public frmRegistrarPedidos(string _usuario = "")
        {
            _NombreUsuario = _usuario;
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".:Neue Bestellung:.";
                label2.Text = "Neuer Ausgang";
                btnsalir.Text = "Beendet";
                label26.Text = "Antragsnummer";
                label27.Text = "Datum der Ausstellung";
                label3.Text = "Produktcode";
                label4.Text = "beschreibung";
                label6.Text = "Menge";
                label8.Text = "Gesamt:";
                btnguardarsalida.Text = "Ausgabe speichern";
                Codigo.HeaderText = "Code";
                Descripcion.HeaderText = "Beschreibung";
                Cantidad.HeaderText = "Menge";
                label5.Text = "Technischer Code";
                label10.Text = "Name des Technikers";
            }
            int precio = 10000;
            for (int i = 0; i < 30; i++)
            {
                comboBox1.Items.Add(precio);
                precio += 5000;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarSalida_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Focus();
            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnbuscarclientes_Click(object sender, EventArgs e)
        {
            using (var form = new mdClientes())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtdoccliente.Text = form._DocumentoCliente;
                    txtnomcliente.Text = form._NombreCliente;
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var form = new mdProductos())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtcodigoproducto.BackColor = Color.Honeydew;
                    _idproducto = form._id;
                    txtcodigoproducto.Text = form._codigo;
                    txtdescripcionproducto.Text = form._descripcion;

                    txtcantidad.Value = 1;
                    txtcantidad.Focus();
                }
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtcodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            string mensaje = string.Empty;
            if (e.KeyData == Keys.Enter)
            {
                Data.Producto pr = ProductoLogica.Instancia.Listar().Where(p => p.Codigo.ToUpper() == txtcodigoproducto.Text.Trim().ToUpper()).FirstOrDefault();
                if (pr != null)
                {
                    txtcodigoproducto.BackColor = Color.Honeydew;
                    txtcodigoproducto.Text = pr.Codigo;
                    txtdescripcionproducto.Text = pr.Descripcion;
                    _idproducto = Convert.ToInt32(pr.IdProducto.ToString());
                    txtcantidad.Value = 1;
                    txtcantidad.Focus();
                }
                else
                {
                    txtcodigoproducto.BackColor = Color.MistyRose;
                }

            }
        }

        private bool producto_agregado()
        {

            bool respuesta = false;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    if (fila.Cells["Id"].Value.ToString() == _idproducto.ToString())
                    {
                        respuesta = true;
                        break;
                    }
                }
            }

            return respuesta;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                total = decimal.Parse(comboBox1.Text);
                count++;
            }


            if (txtcodigoproducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo de producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtdescripcionproducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo de producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (producto_agregado())
            {
                MessageBox.Show("El producto ya está agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtprecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal subtotal = txtcantidad.Value * decimal.Parse(txtprecio.Text);


            total -= subtotal;

            dgvdata.Rows.Add(new object[] {"",
                    _idproducto.ToString(),
                    txtcodigoproducto.Text,
                    txtdescripcionproducto.Text,
                    txtnomcliente.Text,
                    txtcantidad.Text,
                    txtprecio.Text,
                    subtotal.ToString(),
                    comboBox1.Text.ToString(),
                });


            _idproducto = 0;
            txtcodigoproducto.Text = "";
            txtcodigoproducto.BackColor = Color.White;
            txtdescripcionproducto.Text = "";
            txtcantidad.Value = 1;
            txtprecio.Text = "";

            txtcodigoproducto.Focus();

            label11.Text = total.ToString();

            comboBox1.Enabled = false;
        }


        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete17.Width;
                var h = Properties.Resources.delete17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private async void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {
                    int idproducto = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                    int cantidad = Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString());

                    if (await SalidaLogica.Instancia.aumentarStock(idproducto, cantidad))
                    {
                        dgvdata.Rows.RemoveAt(index);
                    }
                }
            }
        }

        private async void btnguardarsalida_Click(object sender, EventArgs e)
        { 
            if (txtdoccliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el documento del tecnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnomcliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del tecnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var olista = new List<Pedido>();
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                olista.Add(new Data.Pedido()
                {

                    NumeroDocumento = txtnumerodocumento.Text.Trim(),
                    CodigoProducto = row.Cells["Codigo"].Value.ToString(),
                    DescripcionProducto = row.Cells["Descripcion"].Value.ToString(),
                    Tecnico = row.Cells["Tecnico"].Value.ToString(),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                    Precio = Convert.ToDouble(row.Cells["Precio"].Value.ToString()),
                    SubTotal = Convert.ToDouble(row.Cells["SubTotal"].Value.ToString()),
                    Presupuesto = Convert.ToInt32(row.Cells["Presupuesto"].Value.ToString()),
                    FechaRegistro = DateTime.Now
                });
            }
             

            bool operaciones = await PedidoLogica.Instancia.Registrar(olista);

            if (operaciones)
            {
                txtdoccliente.Text = "";
                txtnomcliente.Text = "";
                dgvdata.Rows.Clear();
                txtdoccliente.Focus();
                total = 0;
                mdPedidos md = new mdPedidos();
                md._numerodocumento = String.Format("{0:00000}", txtnumerodocumento.Text.Trim());
                md.ShowDialog();
                txtnumerodocumento.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
