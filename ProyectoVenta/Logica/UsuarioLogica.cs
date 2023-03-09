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
    public class UsuarioLogica
    {
        private static UsuarioLogica _instancia = null;

        public UsuarioLogica()
        {

        }

        public static UsuarioLogica Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new UsuarioLogica();
                return _instancia;
            }
        }

    
        public List<Data.Usuario> Listar()
        { 
            List<Data.Usuario> oLista = new List<Data.Usuario>();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    oLista = db.Usuarios.ToList();
                    return oLista;
                }
            }
            catch (Exception ex)
            { 
                return oLista;
            } 
        }

        public bool Existe(string usuario, int defaultid)
        {  
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.Usuario usuarioTemp = db.Usuarios.Where((t)=> t.NombreUsuario == usuario && t.IdUsuario != defaultid).First();

                    return true;
                }
            }
             catch (Exception ex)
             {
                 return false;
             } 
        }

        public async Task<int> Guardar(Data.Usuario objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Usuarios.Add(objeto);
                    await db.SaveChangesAsync();
                    return objeto.IdUsuario;
                }

            }
            catch (Exception)
            {
                return 0;
            } 
        }

        public async Task<bool> Editar(Data.Usuario objeto)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    db.Usuarios.Update(objeto);
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
                    db.Usuarios.Remove(db.Usuarios.Where((t) => t.IdUsuario == id).First());
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            } 
        }

        public Data.Usuario LoginUsuario(string username, string password)
        {
            Data.Usuario user = new();

            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    user = db.Usuarios.Where((t) => t.NombreUsuario.Equals(username) && t.Clave.Equals(password)).First();

                    return user;
                }
            }
            catch (Exception)
            {
                return user;
            }
        }

    }
}
