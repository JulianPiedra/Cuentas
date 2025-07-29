using BussinessLogic;
using DataAccess.Models;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmAgregarCliente : Form
    {
        // Use full file path as key to avoid duplicates
        private Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();

        public FrmAgregarCliente()
        {
            InitializeComponent();
            flpMultimedia.AutoScroll = true;
            FileDialog.FileOk += FileDialog_FileOk;
        }


        private void btnMultimedia_Click(object sender, EventArgs e)
        {
            FileDialog.Multiselect = true;
            FileDialog.ShowDialog();
        }
        void OpenFile(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            string fileName = null;

            if (ctrl is Panel panel)
                fileName = panel.Tag?.ToString();
            else if (ctrl is PictureBox pb && pb.Parent is Panel parentPanel)
                fileName = parentPanel.Tag?.ToString();

            if (string.IsNullOrEmpty(fileName))
                return;

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var fileName in FileDialog.FileNames)
            {
                string ext = Path.GetExtension(fileName).ToLower();

                if (!new[] { ".jpg", ".jpeg", ".png", ".gif", ".mp4", ".mp3", ".wav" }.Contains(ext))
                    continue;

                if (files.ContainsKey(fileName))
                    continue;

                var multimedia = File.ReadAllBytes(fileName);
                files.Add(fileName, multimedia);

                Panel mediaPanel = new Panel
                {
                    Width = 150,
                    Height = 150,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = fileName
                };

                PictureBox thumbnail = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                if (new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(ext))
                {
                    thumbnail.Image = Image.FromFile(fileName);
                }
                else if (new[] { ".mp4", ".mp3", ".wav" }.Contains(ext))
                {
                    thumbnail.Image = Properties.Resources.play_button;
                }

                mediaPanel.Controls.Add(thumbnail);

                mediaPanel.Click += OpenFile;
                thumbnail.Click += OpenFile;


                flpMultimedia.Controls.Add(mediaPanel);
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
                else if (control == flpMultimedia)
                {
                    control.Controls.Clear();
                }
            }
            files.Clear();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                foreach (Control ctrl in this.Controls)
                    ctrl.Enabled = false;

                if (!long.TryParse(txtTelefono.Text, out long telefono))
                {
                    if (string.IsNullOrEmpty(txtTelefono.Text))
                        throw new ArgumentException("El número de teléfono no puede ir vacío.");
                    throw new ArgumentException("El número de teléfono no puede contener caracteres no numéricos.");
                }

                ClienteDAO cliente = new ClienteDAO(
                    txtCedula.Text,
                    txtCorreo.Text,
                    telefono,
                    txtDireccion.Text,
                    txtNombre.Text,
                    files);

                cliente.Validate();

                ClientesLogic logic = new ClientesLogic();

                string result = await Task.Run(() => logic.AgregarCliente(cliente));

                MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                foreach (Control ctrl in this.Controls)
                    ctrl.Enabled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
