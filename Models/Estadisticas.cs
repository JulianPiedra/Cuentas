using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Estadisticas
    {
        public int TotalClientes { get; set; }
        public int TotalCuentas { get; set; }
        public int TotalCuentasActivas { get; set; }
        public decimal MontoTotalCuentas { get; set; }
        public decimal MontoTotalCuentasPendientes { get; set; }

    }
}
