using ProyectoVenta.Herrarmientas;
using ProyectoVenta.Logica;
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

namespace ProyectoVenta.Modales
{
    public partial class mdAcercade : Form
    { 
        public mdAcercade()
        {
            InitializeComponent();
            if (ConfigGeneral.getType() == ConfigGeneral.TYPE_LANGUAGE.ALEMAN)
            {
                label1.Text = "Produktliste";
                CodigoProducto.HeaderText = "Produktcode";
                Descripcion.HeaderText = "Beschreibung";
                Categoria.HeaderText = "Länge";
                Almacen.HeaderText = "speichern";
                Entradas.HeaderText = "Eintrittskarten";
                Salidas.HeaderText = "Abflüge";
                StockActual.HeaderText = "Aktueller Lagerbestand";
                button3.Text = "hinausgehen";
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private bool checkExistData()
        {
            DateTime dt1 = Convert.ToDateTime("01/01/2000");
            DateTime dt2 = Convert.ToDateTime("01/01/2025");

            List<ProyectoVenta.Modelo.Inventario> lista = InventarioLogica.Instancia.Resumen(dt1, dt2);

            foreach (ProyectoVenta.Modelo.Inventario vr in lista)
            {
                if (int.Parse(vr.Stock) <= 5)
                {
                    return true;
                }
            }

            return false;
        }

        private void pushData()
        {
            dgvdata.Rows.Clear();
            
             DateTime dt1 = Convert.ToDateTime("01/01/2000");
            DateTime dt2 = Convert.ToDateTime("01/01/2025");
 
            List<ProyectoVenta.Modelo.Inventario> lista = InventarioLogica.Instancia.Resumen(dt1, dt2);
             
            foreach (ProyectoVenta.Modelo.Inventario vr in lista)
            {
                if (int.Parse(vr.Stock) <= 5) 
                { 
                    dgvdata.Rows.Add(new object[] {
                    vr.Codigo,
                    vr.Descripcion,
                    vr.Categoria,
                    vr.Almacen,
                    vr.Entradas,
                    vr.Salidas,
                    vr.Stock, 
                });
                }
                

            }
 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void mdAcercade_Load(object sender, EventArgs e)
        {

            this.pushData();
            if (!checkExistData())
            {
                MessageBox.Show("No tienes datos actualmente");
                this.Close();
            }
        }
    }
}
