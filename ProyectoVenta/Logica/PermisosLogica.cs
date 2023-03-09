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
    public class PermisosLogica
    {

        private static PermisosLogica _instancia = null;

        public PermisosLogica()
        {

        }

        public static PermisosLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new PermisosLogica();
                return _instancia;
            }
        }
         
        public Data.Permiso Obtener(int idpermisos)
        {
            Permiso obj = new Data.Permiso();
            try
            {
                using(var db = new InventarioAlemanaContext())
                {
                    obj = db.Permisos.Where((t) => t.IdPermisos == idpermisos).First();
                    return obj;
                }             }
            catch (Exception ex)
            {
                return obj;
            } 
        }

        public async Task<bool> Guardar(Permiso objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Permisos.Update(objeto);

                    await db.SaveChangesAsync();
                    return true;
                } 
            }
            catch (Exception ex)
            {
                return false;
            }
             
        }

        internal Permisos Obtener(long idPermisos)
        {
            throw new NotImplementedException();
        }
    }
}
