using DocumentFormat.OpenXml.Drawing.Charts;
using ProyectoVenta.Data;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoVenta.Logica
{
    public class PedidoLogica
    { 
        public static PedidoLogica Instancia = new PedidoLogica();
        
        public async Task<bool> Registrar(List<Pedido> pedido)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                { 
                    foreach (var item in pedido)
                    { 
                        db.Pedidos.Add(item);  
                    }
                    await db.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }

        }



        public List<Pedido> Resumen(DateTime fechainicio, DateTime fechafin)
        {
            List<Pedido> oLista = new List<Pedido>();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Pedidos.Where((t) => t.FechaRegistro > fechainicio && t.FechaRegistro < fechafin).ToList();
                     
                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista;
            }
        }


        public List<Pedido> ListarDetalle(string identrada)
        {
            List<Pedido> oLista = new List<Pedido>();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Pedidos.Where((t) => t.NumeroDocumento == identrada).ToList();
                     
                    return oLista;
                }
            }
            catch (Exception ex)
            {
                return oLista;
            }
        }
    }




}
 
