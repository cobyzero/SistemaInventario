﻿using ProyectoVenta.Modelo;
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



        public List<Inventario> Resumen(string fechainicio = "", string fechafin = "")
        {
            List<Inventario> oLista = new List<Inventario>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select prod.Codigo,prod.Descripcion,prod.Longitud,prod.Almacen,");
                    query.AppendLine("ifnull(ent.Entradas,0)[Entradas],ifnull(sal.Salidas,0)[Salidas],");
                    query.AppendLine("prod.Stock"); 
                    query.AppendLine("from (");
                    query.AppendLine("select DISTINCT * from (");
                    query.AppendLine("select p.IdProducto,p.Codigo,p.Descripcion,p.Longitud,p.Almacen,p.Stock from DETALLE_ENTRADA de");
                    query.AppendLine("inner join ENTRADA e on e.IdEntrada = de.IdEntrada");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = de.IdProducto where DATE(e.FechaRegistro) BETWEEN DATE(@pfechainicio1) AND DATE(@pfechafin1)");
                    query.AppendLine("UNION ALL");
                    query.AppendLine("select p.IdProducto,p.Codigo,p.Descripcion,p.Longitud,p.Almacen,p.Stock from DETALLE_SALIDA ds");
                    query.AppendLine("inner join SALIDA s on s.IdSalida = ds.IdSalida");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = ds.IdProducto where DATE(s.FechaRegistro) BETWEEN DATE(@pfechainicio2) AND DATE(@pfechafin2)");
                    query.AppendLine(") temp");
                    query.AppendLine(") prod");
                    query.AppendLine("left join (");
                    query.AppendLine("select p.IdProducto,sum(de.Cantidad)[Entradas] from PRODUCTO p");
                    query.AppendLine("inner join DETALLE_ENTRADA de on de.IdProducto = p.IdProducto");
                    query.AppendLine("inner join ENTRADA e on e.IdEntrada = de.IdEntrada where DATE(e.FechaRegistro) BETWEEN DATE(@pfechainicio3) AND DATE(@pfechafin3)");
                    query.AppendLine("group by p.IdProducto,p.Codigo,p.Descripcion,p.Longitud,p.Almacen");
                    query.AppendLine(") ent on ent.IdProducto = prod.IdProducto");
                    query.AppendLine("left join (");
                    query.AppendLine("select p.IdProducto,sum(ds.Cantidad)[Salidas] from PRODUCTO p");
                    query.AppendLine("inner join DETALLE_SALIDA ds on ds.IdProducto = p.IdProducto");
                    query.AppendLine("inner join SALIDA s on s.IdSalida = ds.IdSalida where DATE(s.FechaRegistro) BETWEEN DATE(@pfechainicio4) AND DATE(@pfechafin4)");
                    query.AppendLine("group by p.IdProducto");
                    query.AppendLine(") sal on sal.IdProducto = prod.IdProducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SqlParameter("@pfechainicio1", fechainicio));
                    cmd.Parameters.Add(new SqlParameter("@pfechafin1", fechafin));
                    cmd.Parameters.Add(new SqlParameter("@pfechainicio2", fechainicio));
                    cmd.Parameters.Add(new SqlParameter("@pfechafin2", fechafin));
                    cmd.Parameters.Add(new SqlParameter("@pfechainicio3", fechainicio));
                    cmd.Parameters.Add(new SqlParameter("@pfechafin3", fechafin));
                    cmd.Parameters.Add(new SqlParameter("@pfechainicio4", fechainicio));
                    cmd.Parameters.Add(new SqlParameter("@pfechafin4", fechafin));
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Inventario()
                            {
                                Codigo = dr["Codigo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Categoria = dr["Longitud"].ToString(),
                                Almacen = dr["Almacen"].ToString(),
                                Entradas = dr["Entradas"].ToString(),
                                Salidas = dr["Salidas"].ToString(),
                                Stock = dr["Stock"].ToString(), 
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Inventario>();
            }
            return oLista;
        }


    }
}
