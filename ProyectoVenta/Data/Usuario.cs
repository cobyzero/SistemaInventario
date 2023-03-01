using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    public string NombreCompleto { get; set; }

    public string NombreUsuario { get; set; }

    public string Clave { get; set; }

    public long IdPermisos { get; set; }
}
