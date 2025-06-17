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
    public partial class FrmAgregarCuenta : Form
    {
        public FrmAgregarCuenta()
        {
            InitializeComponent();
        }
        public void LlenarSelect()
        {

        }

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            var markedCheckbox = RbMensual.Checked ? 3 : RbQuincenal.Checked ? 2 : RbSemanal.Checked ? 1 : 0;

            label1.Text = markedCheckbox.ToString();
            

        }
    }
}
