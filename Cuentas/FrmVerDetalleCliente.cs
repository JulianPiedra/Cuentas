using BussinessLogic;
using DataAccess.Models;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILogic;
namespace Cuentas
{
    public partial class FrmVerDetalleCliente : Form
    {
        ClienteDAO _cliente;
        public FrmVerDetalleCliente(ClienteDAO cliente)
        {
            InitializeComponent();
            _cliente = cliente;
        }

        private void FrmVerClientes_Load(object sender, EventArgs e)
        {
            ActualizarVista();

        }
        void OpenFile(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            string fileName = null;


            if (ctrl is PictureBox pb)
                fileName = pb.Tag?.ToString();

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


        private void ActualizarVista()
        {
            try
            {

                lblCedula.Text = "Cédula del cliente: " + _cliente.IdCliente;
                lblTelefono.Text = "Telefono: " + _cliente.Telefono;
                lblCorreo.Text = "Correo: " + (string.IsNullOrEmpty(_cliente.Correo) ? "                                          " : _cliente.Correo);
                lblDireccion.Text = "Dirección: " + _cliente.Direccion;
                lblNombre.Text = "Nombre: " + _cliente.Nombre;
                linkLblCuentas.Text = "Cuentas asociadas:\n";
                linkLblCuentas.Links.Clear(); // Limpia cualquier enlace previo

                int startIndex = linkLblCuentas.Text.Length;

                foreach (var cuenta in _cliente.Cuentas)
                {
                    string textoLink = $"Monto de cuenta: {cuenta.Monto:C}\n";
                    linkLblCuentas.Text += textoLink;

                    linkLblCuentas.Links.Add(startIndex, textoLink.Length, cuenta.Cuenta);
                    startIndex += textoLink.Length;
                }

                foreach (var multimedia in _cliente.Files)
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), multimedia.Key);

                    byte[] fileBytes;
                    if (multimedia.Value is byte[] bytes)
                    {
                        fileBytes = bytes;
                    }
                    else
                    {
                        continue;
                    }

                    if (!File.Exists(tempPath))
                    {
                        File.WriteAllBytes(tempPath, fileBytes);
                    }

                    PictureBox thumbnail = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Cursor = Cursors.Hand,
                        Tag = tempPath
                    };

                    string ext = Path.GetExtension(multimedia.Key).ToLower();
                    if (new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(ext))
                    {
                        var image = ByteArrayToImage(fileBytes);
                        if (image != null)
                            thumbnail.Image = image;
                    }
                    else if (new[] { ".mp4", ".mp3", ".wav" }.Contains(ext))
                    {
                        thumbnail.Image = Properties.Resources.play_button;
                    }

                    thumbnail.Click += OpenFile;
                    flpMultimedia.Controls.Add(thumbnail);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (var ms = new System.IO.MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private async void linkLblCuentas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var idCuentaObj = e.Link.LinkData;

            if (int.TryParse(idCuentaObj?.ToString(), out int cuentaId))
            {
                var listaPagos = await ApiFetch.FetchAsync<List<CuentaDAO>>($"/cuentas/{cuentaId}/pagos", HttpMethod.Get, null);

                var frmVerPagos = new FrmVerPagos(listaPagos)
                {
                    Owner = this
                };
                frmVerPagos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo obtener el ID de la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
