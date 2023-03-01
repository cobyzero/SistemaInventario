using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }

    public string NumeroDocumento { get; set; }

    public string NombreCompleto { get; set; }
}
