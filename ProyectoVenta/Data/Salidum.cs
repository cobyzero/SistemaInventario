using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Salidum
{
    [Key]
    public int IdSalida { get; set; }

    public string NumeroDocumento { get; set; }

    public string FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public string DocumentoCliente { get; set; }

    public string NombreCliente { get; set; }

    public int CantidadProductos { get; set; }

    public virtual ICollection<DetalleSalidum> DetalleSalida { get; } = new List<DetalleSalidum>();
}
