using Cuentas;
using System;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmAdministradorDeCuentas : Form
    {
        public FrmAdministradorDeCuentas()
        {
            InitializeComponent();
        }

        private void FrmAdministradorDeCuentas_Load(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVerCuentas>();
        }

        // Cierra formularios hijos si no es del mismo tipo que el que se desea abrir
        private bool CerrarVentanas(Type tipoFormulario)
        {
            var formularioActivo = this.ActiveMdiChild;
            if (formularioActivo != null && formularioActivo.GetType() == tipoFormulario)
                return false;

            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            return true;
        }

        // Método genérico para abrir formularios MDI hijos
        private void AbrirFormulario<T>() where T : Form, new()
        {
            if (CerrarVentanas(typeof(T)))
            {
                var form = new T
                {
                    MdiParent = this
                };
                form.Show();
            }
        }

        // Eventos del menú
        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmAgregarCuenta>();
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVerCuentas>();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmAgregarCliente>();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEstadisticas>();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVerClientes>();
        }
    }
}
