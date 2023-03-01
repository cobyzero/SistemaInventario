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


        public int reducirStock(int idproducto,int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set Stock = Stock - @pcantidad where IdProducto = @pidproducto");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pcantidad", cantidad));
                    cmd.Parameters.Add(new SQLiteParameter("@pidproducto", idproducto));
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1) {
                        mensaje = "no se puede reducir stock";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public int aumentarStock(int idproducto, int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set Stock = Stock + @pcantidad where IdProducto = @pidproducto");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pcantidad", cantidad));
                    cmd.Parameters.Add(new SQLiteParameter("@pidproducto", idproducto));
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                    {
                        mensaje = "no se puede aumentar stock";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public int ObtenerCorrelativo(out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from SALIDA");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    if (respuesta < 1) {
                        mensaje = "No se pudo generar el correlativo";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = "No se pudo generar el correlativo\nMayor Detalle:\n" + ex.Message;
            }

            return respuesta;
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
                    query.AppendLine("de.CodigoProducto,de.DescripcionProducto,de.CategoriaProducto,de.AlmacenProducto,");
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
                                CategoriaProducto = dr["CategoriaProducto"].ToString(),
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







            //List<VistaSalida> oLista = new List<VistaSalida>();
            //try
            //{
            //    using (var db = new BdinventarioContext())
            //    { 
            //        var tempdata = db.Salida.Where(t => new DateTime(t.Fech) > fechainicio && Convert.ToDateTime(t.FechaRegistro) < fechafin);

            //        var data = tempdata.ToList();

            //        foreach (var item in data)
            //        {
            //            var idSalida =  db.DetalleSalida.First(t => t.IdSalida == item.IdSalida);

            //            oLista.Add(new VistaSalida()
            //            {
            //                NumeroDocumento = item.NumeroDocumento,
            //                FechaRegistro = item.FechaRegistro,
            //                UsuarioRegistro = item.UsuarioRegistro,
            //                DocumentoCliente = item.DocumentoCliente,
            //                NombreCliente = item.NombreCliente,
            //                CodigoProducto = idSalida.CodigoProducto,
            //                DescripcionProducto = idSalida.DescripcionProducto,
            //                CategoriaProducto = idSalida.CategoriaProducto,
            //                AlmacenProducto = idSalida.AlmacenProducto,
            //                Cantidad = idSalida.Cantidad.ToString(),
            //            });
            //        }

            //    }

            //}
            //catch (Exception e)
            //{
            //    throw e;
            //    oLista = new List<VistaSalida>();
            //}




            //try
            //{
            //    using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            //    {
            //        conexion.Open();
            //        StringBuilder query = new StringBuilder();

            //        query.AppendLine("select e.NumeroDocumento,strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],e.UsuarioRegistro,");
            //        query.AppendLine("e.DocumentoCliente,e.NombreCliente,");
            //        query.AppendLine("de.CodigoProducto,de.DescripcionProducto,de.CategoriaProducto,de.AlmacenProducto,");
            //        query.AppendLine("de.Cantidad");
            //        query.AppendLine("from SALIDA e");
            //        query.AppendLine("inner join DETALLE_SALIDA de on e.IdSalida = de.IdSalida");
            //        query.AppendLine("where DATE(e.FechaRegistro) BETWEEN DATE(@pfechainicio) AND DATE(@pfechafin)");

            //        SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
            //        cmd.Parameters.Add(new SQLiteParameter("@pfechainicio", fechainicio));
            //        cmd.Parameters.Add(new SQLiteParameter("@pfechafin", fechafin));
            //        cmd.CommandType = System.Data.CommandType.Text;

            //        using (SQLiteDataReader dr = cmd.ExecuteReader())
            //        {
            //            while (dr.Read())
            //            {
            //                oLista.Add(new VistaSalida()
            //                {
            //                    NumeroDocumento = dr["NumeroDocumento"].ToString(),
            //                    FechaRegistro = dr["FechaRegistro"].ToString(),
            //                    UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
            //                    DocumentoCliente = dr["DocumentoCliente"].ToString(),
            //                    NombreCliente = dr["NombreCliente"].ToString(), 
            //                    CodigoProducto = dr["CodigoProducto"].ToString(),
            //                    DescripcionProducto = dr["DescripcionProducto"].ToString(),
            //                    CategoriaProducto = dr["CategoriaProducto"].ToString(),
            //                    AlmacenProducto = dr["AlmacenProducto"].ToString(), 
            //                    Cantidad = dr["Cantidad"].ToString(), 
            //                });
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    oLista = new List<VistaSalida>();
            //}



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
                    query.AppendLine("select CodigoProducto, DescripcionProducto, CategoriaProducto,");
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
                                CategoriaProducto = dr["CategoriaProducto"].ToString(),
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
