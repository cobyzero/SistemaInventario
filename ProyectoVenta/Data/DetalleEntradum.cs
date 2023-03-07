using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class DetalleEntradum
{
    public int IdDetalleEntrada { get; set; }

    public int IdEntrada { get; set; }

    public int IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string LongitudProducto { get; set; }

    public string AlmacenProducto { get; set; }

    public int Cantidad { get; set; }

    public virtual Entradum IdEntradaNavigation { get; set; }
}
