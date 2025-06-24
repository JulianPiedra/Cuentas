using Cuentas;

namespace Cuentas
{
    public partial class FrmAdministradorDeCuentas : Form
    {
        FrmAgregarCuenta frmAgregarCuenta;
        FrmVerCuentas frmVerCuentas;
        FrmAgregarCliente frmAgregarCliente;
        FrmEstadisticas frmEstadisticas;


        public FrmAdministradorDeCuentas(FrmAgregarCuenta frmAgregarCuenta, FrmVerCuentas frmVerCuentas, FrmAgregarCliente frmAgregarCliente, FrmEstadisticas frmEstadisticas)
        {
            this.frmAgregarCuenta = frmAgregarCuenta;
            this.frmVerCuentas = frmVerCuentas;
            this.frmEstadisticas = frmEstadisticas;

            InitializeComponent();
            this.frmAgregarCliente = frmAgregarCliente;
        }

        private void CerrarVentanas()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Hide();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            frmAgregarCuenta.MdiParent = this;
            frmAgregarCuenta.Show();
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            frmVerCuentas.MdiParent = this;
            frmVerCuentas.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            frmAgregarCliente.MdiParent = this;
            frmAgregarCliente.Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            frmEstadisticas.MdiParent = this;
            frmEstadisticas.Show();
        }
    }
}
