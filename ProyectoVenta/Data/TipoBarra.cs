using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoVenta.Data;

public partial class TipoBarra
{
    [Key]
    public int IdTipoBarra { get; set; }

    public long Value { get; set; }
}
