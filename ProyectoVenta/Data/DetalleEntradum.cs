using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class DetalleEntradum
{
    [Key]
    public int IdDetalleEntrada { get; set; }

    public int IdEntrada { get; set; }

    public int IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string CategoriaProducto { get; set; }

    public string AlmacenProducto { get; set; }

    public long Cantidad { get; set; }

    public virtual Entradum IdEntradaNavigation { get; set; }
}
