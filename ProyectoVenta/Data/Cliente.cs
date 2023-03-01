using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    public string NumeroDocumento { get; set; }

    public string NombreCompleto { get; set; }
}
