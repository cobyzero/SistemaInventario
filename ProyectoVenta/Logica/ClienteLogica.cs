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
    public class ClienteLogica
    {

        private static ClienteLogica _instancia = null;

        public ClienteLogica()
        {

        }

        public static ClienteLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ClienteLogica();
                return _instancia;
            }
        }


        public List<Data.Cliente> Listar()
        { 
            List<Data.Cliente> oLista = null;

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Clientes.ToList();
                    return oLista;
                }
            }
            catch (Exception)
            {
                return oLista;
            } 
        }

        public int Existe(string numero, int defaultid, out string mensaje)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Cliente cliente = db.Clientes.Where((t) => t.NumeroDocumento == numero && t.IdCliente != defaultid).First();
                    mensaje = "El numero de documento ya existe";
                    return cliente.IdCliente;
                }
            }
            catch (Exception e)
            {
                mensaje = e.Message;
                return 0;
            } 
        }

        public async Task<int> Guardar(Data.Cliente objeto)
        {  
            try
            {
                using (var db = new InventarioAlemanaContext())
                { 
                    await db.Clientes.AddAsync(objeto); 
                    await db.SaveChangesAsync();
                    return objeto.IdCliente; 
                }
            }
            catch (Exception)
            { 
                return 0;
            } 
        }

        public async Task<bool> Editar(Data.Cliente objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Cliente cliente = db.Clientes.Where((t) => t.IdCliente == objeto.IdCliente).First();

                    cliente = objeto;

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
                    Data.Cliente cliente = db.Clientes.Where((t) => t.IdCliente == id).First();
                    db.Clientes.Remove(cliente);

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
