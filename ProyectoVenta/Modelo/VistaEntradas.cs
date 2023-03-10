using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Modelo
{
    public class VistaEntradas
    {
        public string NumeroDocumento { get; set; }
        public string FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public string DocumentoProveedor { get; set; }
        public string NombreProveedor { get; set; } 
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string AlmacenProducto { get; set; } 
        public string Cantidad { get; set; } 
    }
}
