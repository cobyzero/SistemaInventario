using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Modales
{
    public partial class mdSalidaExitosa : Form
    {
        public string _numerodocumento { get; set; }
        public mdSalidaExitosa()
        {
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".: Nachricht :.";
                label1.Text = "aufgezeichnete Ausgabe";
                label2.Text = "generierte Belegnummer";
                btnaceptar.Text = "akzeptieren";
            }
        }

        private void mdSalidaExitosa_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = _numerodocumento;
            txtnumerodocumento.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
