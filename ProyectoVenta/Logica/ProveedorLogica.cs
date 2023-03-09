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
    public class ProveedorLogica
    {

        private static ProveedorLogica _instancia = null;

        public ProveedorLogica()
        {

        }

        public static ProveedorLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ProveedorLogica();
                return _instancia;
            }
        }


        public List<Data.Proveedor> Listar()
        {
            List<Data.Proveedor> oLista = null;

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Proveedors.ToList();
                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista;
            }

        }

        public bool Existe(string numero, int defaultid)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Proveedor cliente = db.Proveedors.Where((t) => t.IdProveedor != defaultid && t.NumeroDocumento == numero).First(); 
                    return true;
                }
            }
            catch (Exception e)
            { 
                return false;
            }

        }

        public async Task<int> Guardar(Data.Proveedor objeto)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    await db.Proveedors.AddAsync(objeto);
                    await db.SaveChangesAsync();
                    return objeto.IdProveedor;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public async Task<bool> Editar(Data.Proveedor objeto)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Proveedors.Update(objeto);

                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }


        public async Task<bool> Eliminar(int id)
        {
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Proveedor proveedor = db.Proveedors.Where((t) => t.IdProveedor == id).First();
                    db.Proveedors.Remove(proveedor);

                    await db.SaveChangesAsync();
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
