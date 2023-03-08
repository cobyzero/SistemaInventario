using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Salidum
{
    public int IdSalida { get; set; }

    public string NumeroDocumento { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public string DocumentoCliente { get; set; }

    public string NombreCliente { get; set; }

    public int CantidadProductos { get; set; }

    public int IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string LongitudProducto { get; set; }

    public string AlmacenProducto { get; set; }
}
