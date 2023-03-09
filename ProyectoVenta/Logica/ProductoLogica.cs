using ProyectoVenta.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class ProductoLogica
    {
        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }

        public static ProductoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ProductoLogica();
                return _instancia;
            }
        }


        public List<Producto> Listar()
        { 
            List<Producto> oLista = new List<Producto>();
             
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Productos.ToList();
                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista;
            }
        }

        public bool Existe(string codigo, int defaultid)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Producto producto = db.Productos.Where((t) => t.Codigo == codigo || t.IdProducto == defaultid).First();
                    return true;
                }
            }
            catch (Exception)
            {
               return false;
            } 
        }

        public  int Guardar(Data.Producto objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Productos.Add(objeto);

                     db.SaveChanges();

                    return objeto.IdProducto;
                }
            }
            catch (Exception)
            {
                return 0;
            } 
        }

        public async Task<bool> Editar(Data.Producto objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Productos.Update(objeto);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            } 
        }


        public bool Eliminar(int id)
        {
             
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Productos.Remove(db.Productos.Where((t) => t.IdProducto == id).First());
                    return true;
                }
            }
            catch (Exception)
            {

                return false;   
            } 
            
        } 
    }
}
