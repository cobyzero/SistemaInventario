using DocumentFormat.OpenXml.Office.Word;
using NPOI.SS.Formula.Functions;
using ProyectoVenta.Data;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
 

using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Logica
{
    public class SalidaLogica
    {

        private static SalidaLogica _instancia = null;

        public SalidaLogica()
        {

        }

        public static SalidaLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new SalidaLogica();
                return _instancia;
            }
        }


        public async Task<bool> reducirStock(int idproducto,int cantidad)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    var pTemp = db.Productos.Where((t) => t.IdProducto == idproducto).First();
                    pTemp.Stock -= cantidad;

                    await db.SaveChangesAsync();
                     
                    return true;
                }
            }
            catch (Exception e)
            { 
                return false;
            } 
        }

        public async Task<bool> aumentarStock(int idproducto, int cantidad)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    var pTemp = db.Productos.Where((t) => t.IdProducto == idproducto).First();
                    pTemp.Stock += cantidad;

                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            } 
        }
         
        public int ObtenerCorrelativo()
        {
            int count = 0;
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    count = db.Salida.Count() + 1;
                }

                return count;
            }
            catch (Exception)
            {
                return count; 
            }  
        }


        public async Task<bool> Registrar(List<Salidum> detalleSalidum)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                { 
                    foreach (var item in detalleSalidum)
                    { 
                        db.Salida.Add(item);
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

        public List<VistaSalida> Resumen(DateTime fechainicio, DateTime fechafin)
        { 
            List<VistaSalida> oLista = new List<VistaSalida>();
             
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                     List<Data.Salidum> listaSalida = db.Salida.Where((t) => t.FechaRegistro > fechainicio && t.FechaRegistro < fechafin).ToList();

                    for (int i = 0; i < listaSalida.Count(); i++)
                    {
                        Data.Salidum detalle = db.Salida.Where((t) => t.IdSalida == listaSalida[i].IdSalida).First();

                        oLista.Add(new VistaSalida()
                        { 
                        NumeroDocumento = listaSalida[i].NumeroDocumento,
                        FechaRegistro = listaSalida[i].FechaRegistro.ToString(),
                        UsuarioRegistro = listaSalida[i].UsuarioRegistro,
                        DocumentoCliente = listaSalida[i].DocumentoCliente,
                        NombreCliente = listaSalida[i].NombreCliente,
                        CodigoProducto = detalle.CodigoProducto,
                        DescripcionProducto = detalle.DescripcionProducto,
                        CategoriaProducto = detalle.LongitudProducto,
                        AlmacenProducto = detalle.AlmacenProducto,
                        Cantidad = detalle.CantidadProductos.ToString(), 
                     });

                    }

                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista; 
            }
         }


        public Data.Salidum Obtener(string numerodocumento)
        {
            Data.Salidum salida = null;
             
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                   salida = db.Salida.Where((t) => t.NumeroDocumento == numerodocumento).First();

                   return salida;
                }
            }
            catch (Exception)
            {
                return salida; 
            } 
        }

        public List<Salidum> ListarDetalle(int idsalida)
        {
            List<Salidum> oLista = new List<Salidum>();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Salida.Where((t) => t.IdSalida == idsalida).ToList();

                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista;
                
            } 
        }
    }
}
