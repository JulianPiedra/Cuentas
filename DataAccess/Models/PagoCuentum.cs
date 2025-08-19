using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

[PrimaryKey("IdCuenta", "IdPago")]
public partial class PagoCuentum
{
    [Key]
    public int IdCuenta { get; set; }

    [Key]
    public int IdPago { get; set; }

    public DateOnly FechaPago { get; set; }

    public bool Cancelado { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Monto { get; set; }

    public int Multa { get; set; }

    [ForeignKey("IdCuenta")]
    [InverseProperty("PagoCuenta")]
    public virtual Cuentum IdCuentaNavigation { get; set; } = null!;
}
