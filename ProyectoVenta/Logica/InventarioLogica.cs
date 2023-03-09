using ProyectoVenta.Data;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class InventarioLogica
    {
        private static InventarioLogica _instancia = null;

        public InventarioLogica()
        {

        }

        public static InventarioLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new InventarioLogica();
                return _instancia;
            }
        }



        public List<Inventario> Resumen(DateTime fechainicio, DateTime fechafin)
        {
            List<Inventario> oLista = new List<Inventario>();
            try
            { 
                using (var db = new InventarioAlemanaContext())
                {
                    var listaProductos = db.Productos.Where((t)=> t.Stock > 0).ToList();

                    foreach (var item in listaProductos)
                    {
                        var entradaDT = db.Entrada.Where((t) => t.IdProducto == item.IdProducto && t.FechaRegistro > fechainicio && t.FechaRegistro < fechafin).ToList().Count();
                        var salidaDT = db.Salida.Where((t) => t.IdProducto == item.IdProducto && t.FechaRegistro > fechainicio && t.FechaRegistro < fechafin).ToList().Count();


                        if (entradaDT > 0 && salidaDT > 0)
                        {
                            oLista.Add(new Inventario()
                            {
                                Codigo = item.Codigo,
                                Descripcion = item.Descripcion,
                                Categoria = item.Longitud,
                                Almacen = item.Almacen,
                                Entradas = entradaDT.ToString(),
                                Salidas = salidaDT.ToString(),
                                Stock = item.Stock.ToString(),
                            });
                        }

                       
                    }

                    return oLista;
                } 
            }catch(Exception e)
            {
                return oLista;
            }

        }

        public List<Inventario> ResumenAlmacenero()
        {
            List<Inventario> oLista = new List<Inventario>();
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    var listaProductos = db.Productos.Where((t) => t.Stock < 5 && t.Stock > 0).ToList();

                    foreach (var item in listaProductos)
                    {
                        var entradaDT = db.Entrada.Where((t) => t.IdProducto == item.IdProducto).ToList().Count();
                        var salidaDT = db.Salida.Where((t) => t.IdProducto == item.IdProducto).ToList().Count();
                         
                        if (entradaDT > 0 && salidaDT > 0)
                        {
                            oLista.Add(new Inventario()
                            {
                                Codigo = item.Codigo,
                                Descripcion = item.Descripcion,
                                Categoria = item.Longitud,
                                Almacen = item.Almacen,
                                Entradas = entradaDT.ToString(),
                                Salidas = salidaDT.ToString(),
                                Stock = item.Stock.ToString(),
                            });
                        }


                    }

                    return oLista;
                }
            }
            catch (Exception e)
            {
                return oLista;
            }

        }




    }
}
