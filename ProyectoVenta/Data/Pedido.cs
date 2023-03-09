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

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public double SubTotal { get; set; }

    public int Presupuesto { get; set; }

    public DateTime FechaRegistro { get; set; }
}
