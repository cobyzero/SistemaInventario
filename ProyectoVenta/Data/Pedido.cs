using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Pedido
{
    public long IdPedido { get; set; }

    public string NumeroDocumento { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string Tecnico { get; set; }

    public long? Cantidad { get; set; }

    public long? Precio { get; set; }

    public long? SubTotal { get; set; }

    public long? Presupuesto { get; set; }
}
