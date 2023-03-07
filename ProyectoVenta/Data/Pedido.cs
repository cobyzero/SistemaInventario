using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public string NumeroDocumento { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string Tecnico { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public int? SubTotal { get; set; }

    public int? Presupuesto { get; set; }
}
