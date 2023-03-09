using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVenta.Formularios.Pedidos;

namespace ProyectoVenta.Intermedios
{
    public partial class IPedidos : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public IPedidos()
        {
            InitializeComponent();
            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                label7.Text = "Eintrittskarten".ToUpper();
                btnagregar.Text = "Neu";
                btnlistar.Text = "Bericht";
                btnbuscar.Text = "Suchen";
                btncerrar.Text = "Schließen";
            }
             
        }

        private void IEntradas_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmRegistrarPedidos(_NombreUsuario);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmListarPedidos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmDetallePedidos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
