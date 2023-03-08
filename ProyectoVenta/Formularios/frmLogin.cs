using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NPOI.HSSF.Util.HSSFColor;

namespace ProyectoVenta.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                Text = ".:Anmeldung:.";
                label5.Text = "Inventur".ToUpper();
                label2.Text = "Benutzer";
                label3.Text = "Pasword";
                btningresar.Text = "Eingehen";
                btnSalir.Text = "Beendet";
                label4.Text = "Alle Rechte vorbehalten Ⓒ";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ouo.io/RK1tRH");
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ouo.io/VRgLgZ");
        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
            txtusuario.Focus();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            Data.Usuario objuser = UsuarioLogica.Instancia.LoginUsuario(txtusuario.Text, txtclave.Text);


            if (objuser.NombreCompleto == null)
            {
                MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
  
             Inicio frm = new Inicio();
             frm.NombreUsuario = objuser.NombreUsuario;
             frm.Clave = objuser.Clave;
             frm.NombreCompleto = objuser.NombreCompleto;
             frm.FechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
             frm.oPermisos = PermisosLogica.Instancia.Obtener((int)objuser.IdPermisos);
             frm.Show();
             this.Hide();
             frm.FormClosing += Frm_Closing;
           
            
        }

        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.DarkCyan;
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.Teal;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
