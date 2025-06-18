using BussinessLogic;
using DataAccess.Models;
using Models;
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
    public partial class FrmAgregarCliente : Form
    {
        private Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnMultimedia_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var fileName in FileDialog.FileNames)
            {
                if (!fileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) &&
                    !fileName.EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                var multimedia = System.IO.File.ReadAllBytes(fileName);
                if (files.ContainsKey(Path.GetFileName(fileName))) continue;
                files.Add(Path.GetFileName(fileName), multimedia);
                flpMultimedia.Controls.Add(new Label { Text = Path.GetFileName(fileName), AutoSize = true });
            }
        }
        private void LimpiarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is FlowLayoutPanel panel)
                {
                    panel.Controls.Clear();
                    files.Clear();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtTelefono.Text, out int telefono))
                {
                    throw new ArgumentException("El número de teléfono no puede contener caracteres no numéricos.");
                }
                ClienteDAO cliente = new ClienteDAO(
                    txtCedula.Text,
                    txtCorreo.Text,
                    string.IsNullOrEmpty(txtTelefono.Text) ? (int?)null : int.Parse(txtTelefono.Text),
                    txtDireccion.Text,
                    txtNombre.Text,
                    files);
                cliente.Validate();
                ClientesLogic logic = new ClientesLogic();
                string result = logic.AgregarCliente(cliente);
                MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
