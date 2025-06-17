namespace Cuentas
{
    public partial class FrmAdministradorDeCuentas : Form
    {

        public FrmAdministradorDeCuentas()
        {
            InitializeComponent();
        }

        private void CerrarVentanas()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Dispose();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            FrmAgregarCuenta frmCrearCuenta = new FrmAgregarCuenta();
            frmCrearCuenta.MdiParent = this;
            frmCrearCuenta.Show();
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            FrmVerCuentas frmVerCuentas = new FrmVerCuentas();
            frmVerCuentas.MdiParent = this;
            frmVerCuentas.Show();
        }
    }
}
