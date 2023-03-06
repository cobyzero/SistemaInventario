using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Salidum
{
    public long IdSalida { get; set; }

    public string NumeroDocumento { get; set; }

    public string FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public string DocumentoCliente { get; set; }

    public string NombreCliente { get; set; }

    public long CantidadProductos { get; set; }

    public virtual ICollection<DetalleSalidum> DetalleSalida { get; } = new List<DetalleSalidum>();
}
