using Cuentas;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmAdministradorDeCuentas : Form
    {



        public FrmAdministradorDeCuentas()
        {
            InitializeComponent();
        }

        private bool CerrarVentanas(string formName)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null && activeChild.Name == formName)
            {
                return false;
            }
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            return true;
        }



        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrado = CerrarVentanas(((ToolStripMenuItem)sender).Name);
            if (cerrado)
            {
                FrmAgregarCuenta frmAgregarCuenta = new FrmAgregarCuenta();
                frmAgregarCuenta.MdiParent = this;
                frmAgregarCuenta.Show();
            }
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrado = CerrarVentanas(((ToolStripMenuItem)sender).Name);
            if (cerrado)
            {
                FrmVerCuentas frmVerCuentas = new FrmVerCuentas();
                frmVerCuentas.MdiParent = this;
                frmVerCuentas.Show();
            }
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrado = CerrarVentanas(((ToolStripMenuItem)sender).Name);
            if (cerrado)
            {
                FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
                frmAgregarCliente.MdiParent = this;
                frmAgregarCliente.Show();
            }
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrado = CerrarVentanas(((ToolStripMenuItem)sender).Name);
            if (cerrado)
            {
                FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
                frmEstadisticas.MdiParent = this;
                frmEstadisticas.Show();
            }
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrado = CerrarVentanas(((ToolStripMenuItem)sender).Name);
            if (cerrado)
            {
                FrmVerClientes frmVerClientes = new FrmVerClientes();
                frmVerClientes.MdiParent = this;
                frmVerClientes.Show();
            }
        }
    }
}
