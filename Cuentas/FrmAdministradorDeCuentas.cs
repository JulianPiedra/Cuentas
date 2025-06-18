namespace Cuentas
{
    public partial class FrmAdministradorDeCuentas : Form
    {
        FrmAgregarCuenta frmAgregarCuenta;
        FrmVerCuentas frmVerCuentas;
        FrmAgregarCliente frmAgregarCliente;


        public FrmAdministradorDeCuentas(FrmAgregarCuenta frmAgregar, FrmVerCuentas frmVer, FrmAgregarCliente frmAgregarCliente)
        {
            frmAgregarCuenta = frmAgregar;
            frmVerCuentas = frmVer;
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
    }
}
