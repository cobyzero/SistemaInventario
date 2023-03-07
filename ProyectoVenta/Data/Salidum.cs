using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Salidum
{
    public int IdSalida { get; set; }

    public string NumeroDocumento { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public string DocumentoCliente { get; set; }

    public string NombreCliente { get; set; }

    public int CantidadProductos { get; set; }

    public virtual ICollection<DetalleSalidum> DetalleSalida { get; } = new List<DetalleSalidum>();
}
