using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Entradum
{
    public int IdEntrada { get; set; }

    public string NumeroDocumento { get; set; }

    public string FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public string DocumentoProveedor { get; set; }

    public string NombreProveedor { get; set; }

    public string CantidadProductos { get; set; }

    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; } = new List<DetalleEntradum>();
}
