using Microsoft.Data.SqlClient;
using ProyectoVenta.Data;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class EntradaLogica
    {

        private static EntradaLogica _instancia = null;

        public EntradaLogica()
        {

        }

        public static EntradaLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new EntradaLogica();
                return _instancia;
            }
        }


        public Data.Entradum Existe(string numerodocumento)
        {
            Data.Entradum entrada = null;

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    entrada = db.Entrada.Where((t) => t.NumeroDocumento == numerodocumento).First();
                    return entrada;
                }
            }
            catch (Exception)
            {
                return entrada;
            } 
        }


        public async Task<bool> Registrar(Entradum entrada, List<DetalleEntradum> detalleEntrada)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Entrada.Add(entrada);

                    foreach (var item in detalleEntrada)
                    {
                        item.IdEntrada = entrada.IdEntrada;
                        item.IdEntradaNavigation = entrada;
                        db.Entrada.Add(entrada);
                    }

                    await db.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            { 
                return false;
            }
        }

        public List<VistaEntradas> Resumen(DateTime fechainicio, DateTime fechafin)
        {
            List<VistaEntradas> oLista = new List<VistaEntradas>();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    List<Data.Entradum> listaEntrada = db.Entrada.Where((t) => t.FechaRegistro > fechainicio && t.FechaRegistro < fechafin).ToList();

                    for (int i = 0; i < listaEntrada.Count(); i++)
                    {
                        Data.DetalleEntradum detalle = db.DetalleEntrada.Where((t) => t.IdEntrada == listaEntrada[i].IdEntrada).First();

                        oLista.Add(new VistaEntradas()
                        {
                            NumeroDocumento = listaEntrada[i].NumeroDocumento,
                            FechaRegistro = listaEntrada[i].FechaRegistro.ToString(),
                            UsuarioRegistro = listaEntrada[i].UsuarioRegistro,
                            DocumentoProveedor = listaEntrada[i].DocumentoProveedor,
                            NombreProveedor = listaEntrada[i].NombreProveedor,
                            CodigoProducto = detalle.CodigoProducto,
                            DescripcionProducto = detalle.DescripcionProducto,
                            CategoriaProducto = detalle.LongitudProducto,
                            AlmacenProducto = detalle.AlmacenProducto,
                            Cantidad = detalle.Cantidad.ToString(),
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


        public Data.Entradum Obtener(string numerodocumento)
        {
            Data.Entradum entrada = null;

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    entrada = db.Entrada.Where((t) => t.NumeroDocumento == numerodocumento).First();

                    return entrada;
                }
            }
            catch (Exception)
            {
                return entrada;
            }
        }

        public List<DetalleEntrada> ListarDetalle(int identrada)
        {
            List<DetalleEntrada> oLista = new List<DetalleEntrada>();

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select CodigoProducto, DescripcionProducto, LongitudProducto,");
                    query.AppendLine("AlmacenProducto, Cantidad");
                    query.AppendLine("from DETALLE_ENTRADA where IdEntrada = @pidentrada");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SqlParameter("@pidentrada", identrada));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleEntrada()
                            {
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                CategoriaProducto = dr["LongitudProducto"].ToString(),
                                AlmacenProducto = dr["AlmacenProducto"].ToString(), 
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()), 
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<DetalleEntrada>();
            }


            return oLista;
        }






    }
}
