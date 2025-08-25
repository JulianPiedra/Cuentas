using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TipoPago
{
    public int IdTipoPago { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
