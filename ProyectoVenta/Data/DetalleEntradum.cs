using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class DetalleEntradum
{
    public long IdDetalleEntrada { get; set; }

    public long IdEntrada { get; set; }

    public long IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string CategoriaProducto { get; set; }

    public string AlmacenProducto { get; set; }

    public long Cantidad { get; set; }

    public virtual Entradum IdEntradaNavigation { get; set; }
}
