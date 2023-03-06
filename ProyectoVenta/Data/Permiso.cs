using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Permiso
{
    public long IdPermisos { get; set; }

    public string Descripcion { get; set; }

    public long Salidas { get; set; }

    public long Entradas { get; set; }

    public long Productos { get; set; }

    public long Clientes { get; set; }

    public long Proveedores { get; set; }

    public long Inventario { get; set; }

    public long Configuracion { get; set; }
}
