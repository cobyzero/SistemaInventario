using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public string Longitud { get; set; }

    public string Almacen { get; set; }

    public string PrecioCompra { get; set; }

    public string PrecioVenta { get; set; }

    public int Stock { get; set; }
}
