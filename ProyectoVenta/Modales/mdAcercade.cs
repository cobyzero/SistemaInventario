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

            this.pushData();
           
          
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pushData()
        {
            dgvdata.Rows.Clear();

             DateTime dt1 = Convert.ToDateTime("01/01/2000");
            DateTime dt2 = Convert.ToDateTime("01/01/2025");
 
            List<ProyectoVenta.Modelo.Inventario> lista = InventarioLogica.Instancia.Resumen(dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")), dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")));

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
                    vr.TotalIngresos,
                    vr.TotalEgresos
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
    }
}
