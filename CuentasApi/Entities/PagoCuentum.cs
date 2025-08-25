using System;
using System.Collections.Generic;

namespace CuentasApi.Entities;

public partial class PagoCuentum
{
    public int IdCuenta { get; set; }

    public int IdPago { get; set; }

    public DateOnly FechaPago { get; set; }

    public bool Cancelado { get; set; }

    public decimal Monto { get; set; }

    public int Multa { get; set; }

    public virtual Cuentum IdCuentaNavigation { get; set; } = null!;
}
