using BussinessLogic;
using DataAccess.Models;
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
namespace Cuentas
{
    public partial class FrmVerDetalleCliente : Form
    {
        List<Cliente> _cliente;
        public FrmVerDetalleCliente(List<Cliente> cliente)
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
                lblCorreo.Text = "Correo: " + _cliente[0].Correo;
                lblDireccion.Text = "Dirección: " + _cliente[0].Direccion;
                lblNombre.Text = "Nombre: " + _cliente[0].Nombre;

                foreach (var multimedia in _cliente[0].Multimedia)
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), $"{multimedia.IdMultimedia}.{multimedia.Extension}");

                    if (!File.Exists(tempPath))
                    {
                        File.WriteAllBytes(tempPath, multimedia.Multimedia);
                    }

                    PictureBox thumbnail = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Cursor = Cursors.Hand,
                        Tag = tempPath // Guardar ruta para abrirla después
                    };

                    if (new[] { "jpg", "jpeg", "png", "gif" }.Contains(multimedia.Extension.ToLower()))
                    {
                        var image = ByteArrayToImage(multimedia.Multimedia);
                        if (image != null)
                            thumbnail.Image = image;
                    }
                    else if (new[] { "mp4", "mp3", "wav" }.Contains(multimedia.Extension.ToLower()))
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
    }
}
