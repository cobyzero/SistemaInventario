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

namespace ProyectoVenta.Formularios.Entradas
{
    public partial class frmRegistrarEntrada : Form
    {
        private static int _idproducto = 0;
        private static string _categoria = "";
        private static string _almacen = "";
        private static string _NombreUsuario = "";

        public frmRegistrarEntrada(string _usuario = "")
        {
            _NombreUsuario = _usuario;
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".: Neuer Eintrag :.";
                label2.Text = "Neuer Eintrag";
                btnsalir.Text = "hinausgehen";
                label26.Text = "Dokumentnummer";
                label27.Text = "Registrierungsdatum";
                label5.Text = "Lieferantendokument";
                label10.Text = "Anbietername";
                label3.Text = "Produktcode";
                label4.Text = "Produktbeschreibung";
                label6.Text = "Menge";
                Codigo.HeaderText = "Code";
                Descripcion.HeaderText = "Beschreibung";
                Cantidad.HeaderText = "Menge";
                btnguardarentrada.Text = "Eintrag speichern";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Focus();
            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var form = new mdProveedores())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtdocproveedor.Text = form._DocumentoProveedor;
                    txtnomproveedor.Text = form._NombreProveedor;
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
                    _categoria = form._categoria;
                    _almacen = form._almacen;
                     
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
                    _categoria = pr.Longitud;
                    _almacen = pr.Almacen;
                     
                }
                else {
                    txtcodigoproducto.BackColor = Color.MistyRose;
                }

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodigoproducto.Text.Trim() == "") {
                MessageBox.Show("Debe ingresar el codigo de producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtdescripcionproducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo de producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            if (producto_agregado()) {

                MessageBox.Show("El producto ya está agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
             
            dgvdata.Rows.Add(new object[] {"",
                _idproducto.ToString(),
                txtcodigoproducto.Text,
                txtdescripcionproducto.Text,

               txtcantidad.Value.ToString(),
                _categoria,

                _almacen,
            });
             

            _idproducto = 0;
            txtcodigoproducto.Text = "";
            txtcodigoproducto.BackColor = Color.White;
            txtdescripcionproducto.Text = "";
            _categoria = "";
            _almacen = "";  
            txtcantidad.Value = 0;
            txtcodigoproducto.Focus();
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

        private bool producto_agregado() {

            bool respuesta = false;
            if (dgvdata.Rows.Count > 0) {
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

       

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {
                    dgvdata.Rows.RemoveAt(index); 
                }
            }
        }

        private async void btnguardarentrada_Click(object sender, EventArgs e)
        {
            if (txtnumerodocumento.Text.Trim() == "") {
                MessageBox.Show("Debe ingresar el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtdocproveedor.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el documento del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnomproveedor.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1) {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
             
            int cantidad_productos = 0;

             
            if (EntradaLogica.Instancia.Existe(txtnumerodocumento.Text) != null) {
                MessageBox.Show("Numero de documento ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            List<Data.Entradum> olista = new List<Entradum>();

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                olista.Add(new Entradum() {
                    IdProducto = Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                    CodigoProducto = row.Cells["Codigo"].Value.ToString(),
                    DescripcionProducto = row.Cells["Descripcion"].Value.ToString(),
                    LongitudProducto = row.Cells["Longitud"].Value.ToString(),
                    AlmacenProducto = row.Cells["Almacen"].Value.ToString(), 
                    CantidadProductos = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                    NumeroDocumento = txtnumerodocumento.Text,
                    FechaRegistro = DateTime.Now,
                    UsuarioRegistro = _NombreUsuario,
                    DocumentoProveedor = txtdocproveedor.Text,
                    NombreProveedor = txtnomproveedor.Text,
                });
                 
                cantidad_productos += Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
            }

             
            
            if (await EntradaLogica.Instancia.Registrar(olista))
            {
                txtnumerodocumento.Text = "";
                txtdocproveedor.Text = "";
                txtnomproveedor.Text = "";
                dgvdata.Rows.Clear();

                txtnumerodocumento.Focus();

                MessageBox.Show("Entrada registrada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            } 


        }
    }
}
