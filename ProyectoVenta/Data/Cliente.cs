using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class Cliente
{
    public long IdCliente { get; set; }

    public string NumeroDocumento { get; set; }

    public string NombreCompleto { get; set; }
}
