using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreCompleto { get; set; }

    public string NombreUsuario { get; set; }

    public string Clave { get; set; }

    public int IdPermisos { get; set; }
}
