using System;
using System.Collections.Generic;

namespace CuentasApi.Entities;

public partial class TipoPago
{
    public int IdTipoPago { get; set; }

    public string Nombre { get; set; } = null!;
}
