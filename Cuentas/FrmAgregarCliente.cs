using BussinessLogic;
using DataAccess.Models;
using Models;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace Cuentas
{
    public partial class FrmAgregarCliente : Form
    {
        private Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();
        private LibVLC _libVLC;

        public FrmAgregarCliente()
        {
            InitializeComponent();
            Core.Initialize();  
            _libVLC = new LibVLC();
            flpMultimedia.AutoScroll = true;
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnMultimedia_Click(object sender, EventArgs e)
        {
            FileDialog.Multiselect = true;
            FileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var fileName in FileDialog.FileNames)
            {
                string ext = Path.GetExtension(fileName).ToLower();

                if (!new[] { ".jpg", ".jpeg", ".png", ".gif", ".mp4", ".mp3", ".wav" }.Contains(ext))
                    continue;

                if (files.ContainsKey(Path.GetFileName(fileName))) continue;

                var multimedia = File.ReadAllBytes(fileName);
                files.Add(ext, multimedia);

                Panel mediaPanel = new Panel
                {
                    Width = 320,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(ext))
                {
                    PictureBox pb = new PictureBox
                    {
                        Image = Image.FromFile(fileName),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Fill
                    };
                    mediaPanel.Controls.Add(pb);
                }
                else if (new[] { ".mp4", ".mp3", ".wav" }.Contains(ext))
                {
                    var mediaPlayer = new MediaPlayer(_libVLC);
                    var videoView = new VideoView
                    {
                        MediaPlayer = mediaPlayer,
                        Width = 320,
                        Height = 200,
                        Dock = DockStyle.Top
                    };

                    var media = new Media(_libVLC, new Uri(fileName));
                    mediaPlayer.Play(media);


                    FlowLayoutPanel controlsPanel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Bottom,
                        FlowDirection = FlowDirection.LeftToRight,
                        Padding = new Padding(100, 0, 100, 0),
                        AutoSize = true
                    };

                    Button btnPlay = new Button { Text = "▶️", Width = 35, Height = 40, Font = new Font("Segoe UI", 12) };
                    btnPlay.Click += (s, ev) =>
                    {
                        if (!mediaPlayer.IsPlaying)
                            mediaPlayer.Play();
                    };

                    Button btnPause = new Button { Text = "⏸️", Width = 35, Height = 40, Font = new Font("Segoe UI", 12) };
                    btnPause.Click += (s, ev) =>
                    {
                        if (mediaPlayer.IsPlaying)
                            mediaPlayer.Pause();
                    };

                    Button btnStop = new Button { Text = "⏹️", Width = 35, Height = 40, Font = new Font("Segoe UI", 12) };
                    btnStop.Click += (s, ev) =>
                    {
                        if (mediaPlayer.IsPlaying)
                            mediaPlayer.Stop();
                    };

                    controlsPanel.Controls.Add(btnPlay);
                    controlsPanel.Controls.Add(btnPause);
                    controlsPanel.Controls.Add(btnStop);

                    mediaPanel.Controls.Add(videoView);
                    mediaPanel.Controls.Add(controlsPanel);
                    mediaPlayer.Pause();

                }

                flpMultimedia.Controls.Add(mediaPanel);
            }
        }

        private void LimpiarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
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
                
                if (!long.TryParse(txtTelefono.Text, out long telefono)){
                    if (txtTelefono.Text.IsNullOrEmpty())
                        throw new ArgumentException("El número de teléfono no puede ir vacio.");
                    throw new ArgumentException("El número de teléfono no puede contener caracteres no numéricos.");
                }
               


                ClienteDAO cliente = new ClienteDAO(
                    txtCedula.Text,
                    txtCorreo.Text,
                    long.Parse(txtTelefono.Text),
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
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Control ctrl in flpMultimedia.Controls)
            {
                if (ctrl is Panel panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is VideoView videoView)
                        {
                            videoView.MediaPlayer?.Stop();
                            videoView.MediaPlayer?.Dispose();
                            videoView.Dispose();
                        }
                    }
                }
            }
            _libVLC.Dispose();

            base.OnFormClosing(e);
        }
    }
}
