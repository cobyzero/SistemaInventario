using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Permiso
{
    public int IdPermisos { get; set; }

    public string Descripcion { get; set; }

    public int Salidas { get; set; }

    public int Entradas { get; set; }

    public int Productos { get; set; }

    public int Clientes { get; set; }

    public int Proveedores { get; set; }

    public int Inventario { get; set; }

    public int Configuracion { get; set; }
}
