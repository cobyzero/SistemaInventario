using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Dato
{
    [Key]
    public int IdDato { get; set; }

    public string RazonSocial { get; set; }

    public string Ruc { get; set; }

    public string Direccion { get; set; }

    public byte[] Logo { get; set; }
}
