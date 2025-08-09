using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IdCliente { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Correo { get; set; }

    public long Telefono { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Direccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Multimedium> Multimedia { get; set; } = new List<Multimedium>();
}
