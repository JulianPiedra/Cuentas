using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Cuentum
{
    public int IdCuenta { get; set; }

    public string IdCliente { get; set; } = null!;

    public decimal Monto { get; set; }

    public int Cuotas { get; set; }

    public int Canceladas { get; set; }

    public DateOnly SiguientePago { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<PagoCuentum> PagoCuenta { get; set; } = new List<PagoCuentum>();
}
