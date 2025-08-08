using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class Cuentum
{
    [Key]
    public int IdCuenta { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IdCliente { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Monto { get; set; }

    public int Cuotas { get; set; }

    public int Canceladas { get; set; }

    public DateOnly SiguientePago { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Cuenta")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    [InverseProperty("IdCuentaNavigation")]
    public virtual ICollection<PagoCuentum> PagoCuenta { get; set; } = new List<PagoCuentum>();
}
