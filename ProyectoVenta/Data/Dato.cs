using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Dato
{
    public long IdDato { get; set; }

    public string RazonSocial { get; set; }

    public string Ruc { get; set; }

    public string Direccion { get; set; }

    public byte[] Logo { get; set; }
}
