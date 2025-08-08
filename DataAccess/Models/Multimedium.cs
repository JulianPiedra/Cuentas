using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

[PrimaryKey("IdCliente", "IdMultimedia")]
public partial class Multimedium
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IdCliente { get; set; } = null!;

    [Key]
    public int IdMultimedia { get; set; }

    public byte[] Multimedia { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Extension { get; set; } = null!;

    [ForeignKey("IdCliente")]
    [InverseProperty("Multimedia")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
