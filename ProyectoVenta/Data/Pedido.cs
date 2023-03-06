using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Pedido
{
    public long IdPedido { get; set; }

    public long? CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string LongitudProducto { get; set; }

    public long? Cantidad { get; set; }

    public long? Stock { get; set; }

    public long? Precio { get; set; }

    public long? Total { get; set; }

    public long? Presupuesto { get; set; }
}
