using System;
using System.Collections.Generic;

namespace CuentasApi.Entities;

public partial class Multimedium
{
    public string IdCliente { get; set; } = null!;

    public int IdMultimedia { get; set; }

    public byte[] Multimedia { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
