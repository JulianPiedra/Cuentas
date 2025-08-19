using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PagoCuentaDAO
    {
        public int IdCuenta { get; set; }

        public int IdPago { get; set; }

        public DateOnly FechaPago { get; set; }

        public bool Cancelado { get; set; }

        [Column(TypeName = "numeric(10, 2)")]
        public decimal Monto { get; set; }

        public int Multa { get; set; }

    }
}
