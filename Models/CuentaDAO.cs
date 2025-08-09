using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CuentaDAO
    {

        public int Cuenta { get; set; }

        public string IdCliente { get; set; } = null!;

        public decimal Monto { get; set; }

        public int Cuotas { get; set; }

        public int Canceladas { get; set; }
        public string SiguientePago { get; set; }

        
        public List<PagoCuentaDAO> PagosCuenta { get; set; }

        public CuentaDAO()
        {
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(IdCliente))
            {
                throw new ArgumentException("Cliente no seleccionado.");
            }
            if (Monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor a cero.");
            }
            if (Cuotas <= 0)
            {
                throw new ArgumentException("El número de cuotas debe ser mayor a cero.");
            }
            if (Canceladas < 0 || Canceladas > Cuotas)
            {
                throw new ArgumentException("El número de cuotas canceladas no puede ser negativo o mayor que el total de cuotas.");
            }
            if (PagosCuenta == null || PagosCuenta.Count == 0)
            {
                throw new ArgumentException("Debe haber al menos una cuota a pagar.");
            }
        }
    }
}

