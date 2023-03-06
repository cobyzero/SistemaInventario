using System;
using System.Collections.Generic;

namespace ProyectoVenta.Data;

public partial class DetalleSalidum
{
    public long IdDetalleSalida { get; set; }

    public long IdSalida { get; set; }

    public long IdProducto { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public string LongitudProducto { get; set; }

    public string AlmacenProducto { get; set; }

    public long Cantidad { get; set; }

    public virtual Salidum IdSalidaNavigation { get; set; }
}
