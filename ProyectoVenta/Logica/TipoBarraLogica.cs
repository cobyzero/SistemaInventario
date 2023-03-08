﻿using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class TipoBarraLogica
    {

        private static TipoBarraLogica _instancia = null;

        public TipoBarraLogica()
        {

        }

        public static TipoBarraLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new TipoBarraLogica();
                return _instancia;
            }
        }

        public TipoBarra ObtenerTipoBarra()
        {
            TipoBarra obj = new TipoBarra();
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=InventarioAlemana.mssql.somee.com;Database=InventarioAlemana;user id=cobyzero_SQLLogin_1;pwd=6r4zkblesj;persist security info=False;packet size=4096;Encrypt=false"))
                {
                    conexion.Open();
                    string query = "select IdTipoBarra,Value from TIPO_BARRA where IdTipoBarra = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new TipoBarra()
                            {
                                IdTipoBarra = int.Parse(dr["IdTipoBarra"].ToString()),
                                Value = int.Parse(dr["Value"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = new TipoBarra();
            }
            return obj;
        }

        public int Guardar(int valor, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=InventarioAlemana.mssql.somee.com;Database=InventarioAlemana;user id=cobyzero_SQLLogin_1;pwd=6r4zkblesj;persist security info=False;packet size=4096;Encrypt=false"))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update TIPO_BARRA set Value = @pvalue");
                    query.AppendLine("where IdTipoBarra = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SqlParameter("@pvalue", valor));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el tipo de barra";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

    }
}
