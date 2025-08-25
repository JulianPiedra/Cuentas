using System;
using System.Collections.Generic;

namespace CuentasApi.Entities;

public partial class TipoCuentum
{
    public int IdTipoCuenta { get; set; }

    public string Nombre { get; set; } = null!;
}
