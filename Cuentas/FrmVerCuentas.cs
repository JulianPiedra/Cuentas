using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmVerCuentas : Form
    {
        public FrmVerCuentas()
        {
            InitializeComponent();
        }

        private void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            // Agregar filas de prueba
            DgvCuentas.Rows.Add("Marta", "₡10,000", "5", "2", "15/06/2025");
            DgvCuentas.Rows.Add("Pedro", "₡20,000", "10", "5", "20/06/2025");
            DgvCuentas.Rows.Add("Daniel", "₡15,500", "6", "6", "Pagada");

        }
    }
}
