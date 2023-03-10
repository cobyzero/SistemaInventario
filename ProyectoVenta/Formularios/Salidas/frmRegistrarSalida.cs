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

namespace ProyectoVenta.Formularios.Salidas
{
    public partial class frmRegistrarSalidas : Form
    {
        private static int _idproducto = 0;
        private static string _categoria = "";
        private static string _almacen = "";
        private static int _stock = 0;

        private static string _NombreUsuario = "";

        public frmRegistrarSalidas(string _usuario = "")
        {
            _NombreUsuario = _usuario;
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".:Neuer Ausgang:.";
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
                txtnumerodocumento.Text = "automatisch generiert";
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
                    txtstock.Text = form._stock.ToString();
                    _categoria = form._categoria;
                    _almacen = form._almacen;
                    _stock = form._stock;

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
                    txtstock.Text = pr.Stock.ToString();
                    _idproducto = Convert.ToInt32(pr.IdProducto.ToString());
                    _categoria = pr.Longitud;
                    _almacen = pr.Almacen;
                    _stock = pr.Stock;

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

        private async void btnagregar_Click(object sender, EventArgs e)
        {
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

            if (txtcantidad.Value > _stock)
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
             
             
            if (await SalidaLogica.Instancia.reducirStock(_idproducto, Convert.ToInt32(txtcantidad.Value.ToString())))
            {
                dgvdata.Rows.Add(new object[] {"",
                    _idproducto.ToString(),
                    txtcodigoproducto.Text,
                    txtdescripcionproducto.Text,
                    _categoria,
                    _almacen,
                    txtcantidad.Value.ToString(),
                });
 
                _idproducto = 0;
                txtcodigoproducto.Text = "";
                txtcodigoproducto.BackColor = Color.White;
                txtdescripcionproducto.Text = "";
                txtstock.Text = "";
                _categoria = "";
                _almacen = "";
                _stock = 0;
                txtcantidad.Value = 1;
                txtcodigoproducto.Focus();
            } 
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
             
            int cantidad_productos = 0;
            int idcorrelativo = SalidaLogica.Instancia.ObtenerCorrelativo();

            List<Salidum> olista = new List<Salidum>();

            if (idcorrelativo < 1)
            { 
                return;
            }

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                olista.Add(new Salidum()
                {
                    IdProducto = Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                    CodigoProducto = row.Cells["Codigo"].Value.ToString(),
                    DescripcionProducto = row.Cells["Descripcion"].Value.ToString(),
                    LongitudProducto = row.Cells["Longitud"].Value.ToString(),
                    AlmacenProducto = row.Cells["Almacen"].Value.ToString(),
                    CantidadProductos = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                    NumeroDocumento = String.Format("{0:00000}", idcorrelativo),
                    FechaRegistro = DateTime.Now,
                    UsuarioRegistro = _NombreUsuario,
                    DocumentoCliente = txtdoccliente.Text,
                    NombreCliente = txtnomcliente.Text,
                });

                cantidad_productos += Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
            }
 

            bool operaciones = await SalidaLogica.Instancia.Registrar(olista);

            if (operaciones)
            {
                txtdoccliente.Text = "";
                txtnomcliente.Text = "";
                dgvdata.Rows.Clear();
                txtdoccliente.Focus();

                mdSalidaExitosa md = new mdSalidaExitosa();
                md._numerodocumento = String.Format("{0:00000}", idcorrelativo);
                md.ShowDialog();
            }
           


        }
    }
}
