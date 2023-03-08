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
    public class DatoLogica
    {

        private static DatoLogica _instancia = null;

        public DatoLogica()
        {

        }

        public static DatoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new DatoLogica();
                return _instancia;
            }
        }

   

        public Data.Dato Obtener()
        {
            Data.Dato obj = new Data.Dato();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    obj = db.Datos.Where((t) => t.IdDato == 1).First();
                }
            }
            catch (Exception ex)
            {
                obj = new Data.Dato();
            }
            return obj;
        }

        public async Task<bool> Guardar(Data.Dato objeto)
        { 
            try
            {
                 using(var db = new InventarioAlemanaContext())
                 {
                    Data.Dato dato = db.Datos.Where((t) => t.IdDato == 1).First();

                    dato = objeto;

                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
             
        }

        public int ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=InventarioAlemana.mssql.somee.com;Database=InventarioAlemana;user id=cobyzero_SQLLogin_1;pwd=6r4zkblesj;persist security info=False;packet size=4096;Encrypt=false"))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update DATOS set Logo = @pimagen");
                    query.AppendLine("where IdDato = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    SqlParameter parameter = new SqlParameter("@pimagen", System.Data.DbType.Binary);
                    parameter.Value = imagen;
                    cmd.Parameters.Add(parameter);
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el logo";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] obj = new byte[0];
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=InventarioAlemana.mssql.somee.com;Database=InventarioAlemana;user id=cobyzero_SQLLogin_1;pwd=6r4zkblesj;persist security info=False;packet size=4096;Encrypt=false"))
                {
                    conexion.Open();
                    string query = "select Logo from DATOS where IdDato = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = (byte[])dr["Logo"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                obj = new byte[0];
            }
            return obj;
        }


    }
}
