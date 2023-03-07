using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class DetalleSalidum
{
    public int IdDetalleSalida { get; set; }

    public int IdSalida { get; set; }

    public int IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string LongitudProducto { get; set; }

    public string AlmacenProducto { get; set; }

    public int Cantidad { get; set; }

    public virtual Salidum IdSalidaNavigation { get; set; }
}
