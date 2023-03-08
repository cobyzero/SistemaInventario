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

        public Data.TipoBarra ObtenerTipoBarra()
        {
            Data.TipoBarra obj = new Data.TipoBarra();
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    obj = db.TipoBarras.Where((t) => t.IdTipoBarra == 1).First();

                    return obj;
                } 
            }
            catch (Exception ex)
            {
                return obj;
            } 
        }

        public async Task<bool> Guardar(int valor)
        { 
            try
            {
                using (var db = new InventarioAlemanaContext())
                {
                    Data.TipoBarra tipoBarra = db.TipoBarras.Where((t) => t.IdTipoBarra == 1).First();
                    tipoBarra.Value = valor;

                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

    }
}
