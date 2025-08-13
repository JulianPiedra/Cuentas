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
        List<ClienteDAO> _cliente;
        public FrmVerDetalleCliente(List<ClienteDAO> cliente)
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

                lblCedula.Text = "Cédula del cliente: " + _cliente[0].IdCliente;
                lblTelefono.Text = "Telefono: " + _cliente[0].Telefono;
                lblCorreo.Text = "Correo: " + (string.IsNullOrEmpty(_cliente[0].Correo) ? "                    " : _cliente[0].Correo);
                lblDireccion.Text = "Dirección: " + _cliente[0].Direccion;
                lblNombre.Text = "Nombre: " + _cliente[0].Nombre;
                linkLblCuentas.Text = "Cuentas asociadas:\n";
                linkLblCuentas.Links.Clear(); // Limpia cualquier enlace previo

                int startIndex = linkLblCuentas.Text.Length;

                foreach (var cuenta in _cliente[0].Cuentas)
                {
                    string textoLink = $"Monto de cuenta: {cuenta.Monto:C}\n";
                    linkLblCuentas.Text += textoLink;

                    linkLblCuentas.Links.Add(startIndex, textoLink.Length, cuenta.Cuenta);
                    startIndex += textoLink.Length;
                }

                foreach (var multimedia in _cliente[0].Files)
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), $"{multimedia.Key}");

                    if (!File.Exists(tempPath))
                    {
                        File.WriteAllBytes(tempPath, multimedia.Value);
                    }

                    PictureBox thumbnail = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Cursor = Cursors.Hand,
                        Tag = tempPath // Guardar ruta para abrirla después
                    };

                    if (new[] { "jpg", "jpeg", "png", "gif" }.Contains(multimedia.Key.ToLower()))
                    {
                        var image = ByteArrayToImage(multimedia.Value);
                        if (image != null)
                            thumbnail.Image = image;
                    }
                    else if (new[] { "mp4", "mp3", "wav" }.Contains(multimedia.Key.ToLower()))
                    {
                        thumbnail.Image = Properties.Resources.play_button; // Icono genérico
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
