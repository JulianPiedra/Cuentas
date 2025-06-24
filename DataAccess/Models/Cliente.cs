using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Cliente
{
    public string IdCliente { get; set; } = null!;

    public string? Correo { get; set; }

    public long Telefono { get; set; }

    public string Direccion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<Multimedium> Multimedia { get; set; } = new List<Multimedium>();
}
