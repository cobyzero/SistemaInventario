using DocumentFormat.OpenXml.Office.Word;
using NPOI.SS.Formula.Functions;
using ProyectoVenta.Data;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
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
                using (var db = new BdinventarioContext())
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
                using (var db = new BdinventarioContext())
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
                using (var db = new BdinventarioContext())
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


        public async Task<bool> Registrar(Salidum salidum, List<DetalleSalidum> detalleSalidum)
        {
            try
            {
                using (var db = new BdinventarioContext())
                {
                    db.Salida.Add(salidum);

                    foreach (var item in detalleSalidum)
                    {
                        item.IdSalida = salidum.IdSalida;
                        item.IdSalidaNavigation = salidum;
                        db.DetalleSalida.Add(item);
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

        public List<VistaSalida> Resumen(string fechainicio = "", string fechafin = "")
        {
 
            List<VistaSalida> oLista = new List<VistaSalida>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select e.NumeroDocumento,strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],e.UsuarioRegistro,");
                    query.AppendLine("e.DocumentoCliente,e.NombreCliente,");
                    query.AppendLine("de.CodigoProducto,de.DescripcionProducto,de.LongitudProducto,de.AlmacenProducto,");
                    query.AppendLine("de.Cantidad");
                    query.AppendLine("from SALIDA e");
                    query.AppendLine("inner join DETALLE_SALIDA de on e.IdSalida = de.IdSalida");
                    query.AppendLine("where DATE(e.FechaRegistro) BETWEEN DATE(@pfechainicio) AND DATE(@pfechafin)");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pfechainicio", fechainicio));
                    cmd.Parameters.Add(new SQLiteParameter("@pfechafin", fechafin));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new VistaSalida()
                            {
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                CategoriaProducto = dr["LongitudProducto"].ToString(),
                                AlmacenProducto = dr["AlmacenProducto"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<VistaSalida>();
            }
             return oLista;
        }


        public Salida Obtener(string numerodocumento)
        {
            Salida objeto = null;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdSalida,NumeroDocumento, strftime('%d/%m/%Y', date(FechaRegistro))[FechaRegistro],UsuarioRegistro,DocumentoCliente,");
                    query.AppendLine("NombreCliente,CantidadProductos from SALIDA");
                    query.AppendLine("where NumeroDocumento = @pnumero");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnumero", numerodocumento));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new Salida()
                            {
                                IdSalida = Convert.ToInt32(dr["IdSalida"].ToString()),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CantidadProductos = Convert.ToInt32(dr["CantidadProductos"].ToString()), 
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objeto = null;
            }
            return objeto;
        }

        public List<DetalleSalida> ListarDetalle(int idsalida)
        {
            List<DetalleSalida> oLista = new List<DetalleSalida>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select CodigoProducto, DescripcionProducto, LongitudProducto,");
                    query.AppendLine("AlmacenProducto, Cantidad");
                    query.AppendLine("from DETALLE_SALIDA where IdSalida = @pidsalida");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pidsalida", idsalida));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleSalida()
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
                oLista = new List<DetalleSalida>();
            }


            return oLista;
        }






    }
}
