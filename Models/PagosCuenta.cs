using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PagosCuenta
    {
        public DateOnly FechaPago { get; set; }
        public bool Cancelado { get; set; }
    }
}
