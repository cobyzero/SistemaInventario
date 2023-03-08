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

        public async Task<bool> ActualizarLogo(byte[] imagen)
        {  
            try
            { 
                using (var db = new InventarioAlemanaContext())
                {

                    Data.Dato dato = db.Datos.Where((t) => t.IdDato == 1).First();

                    dato.Logo = imagen;

                    await db.SaveChangesAsync(); 
                    
                    return true;
                }
            }
            catch (Exception ex)
            { 
                return false;
            } 
        }

        public byte[] ObtenerLogo()
        { 
            byte[] obj = new byte[0];
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Dato dato = db.Datos.Where((t) => t.IdDato == 1).First();

                    obj = dato.Logo;

                    return obj;
                }
            }
            catch (Exception ex)
            {
                return obj;
            } 
        } 
    }
}
