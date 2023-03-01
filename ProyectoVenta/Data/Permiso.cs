using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Permiso
{
    [Key]
    public int IdPermisos { get; set; }

    public string Descripcion { get; set; }

    public long Salidas { get; set; }

    public long Entradas { get; set; }

    public long Productos { get; set; }

    public long Clientes { get; set; }

    public long Proveedores { get; set; }

    public long Inventario { get; set; }

    public long Configuracion { get; set; }
}
