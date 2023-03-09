using DocumentFormat.OpenXml.Drawing.Charts;
using ProyectoVenta.Data;
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


        public int GetNumeroId()
        {
            int id = 0;
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    foreach (var item in db.Pedidos)
                    {
                        if (item.IdPedido > id)
                        {
                            id = (int)item.IdPedido;
                        }
                    }

                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }        
        }
    }


    
}
