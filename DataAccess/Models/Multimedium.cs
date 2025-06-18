using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Multimedium
{
    public string IdCliente { get; set; } = null!;

    public int IdMultimedia { get; set; }

    public byte[] Multimedia { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
