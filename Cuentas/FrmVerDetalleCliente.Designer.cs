namespace Cuentas
{
    partial class FrmVerDetalleCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCedula = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblApuntes = new Label();
            linkLblCuentas = new LinkLabel();
            btnEditar = new Button();
            flpMultimedia = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblCedula);
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Controls.Add(lblTelefono);
            flowLayoutPanel1.Controls.Add(lblDireccion);
            flowLayoutPanel1.Controls.Add(lblCorreo);
            flowLayoutPanel1.Controls.Add(lblApuntes);
            flowLayoutPanel1.Controls.Add(linkLblCuentas);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(553, 855);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 12F);
            lblCedula.Location = new Point(6, 49);
            lblCedula.Margin = new Padding(6, 49, 64, 49);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(0, 21);
            lblCedula.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(76, 49);
            lblNombre.Margin = new Padding(6, 49, 64, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(146, 49);
            lblTelefono.Margin = new Padding(6, 49, 64, 49);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(0, 21);
            lblTelefono.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(216, 49);
            lblDireccion.Margin = new Padding(6, 49, 64, 49);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 21);
            lblDireccion.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(286, 49);
            lblCorreo.Margin = new Padding(6, 49, 64, 49);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(0, 21);
            lblCorreo.TabIndex = 10;
            // 
            // lblApuntes
            // 
            lblApuntes.AutoSize = true;
            lblApuntes.Font = new Font("Segoe UI", 12F);
            lblApuntes.Location = new Point(356, 49);
            lblApuntes.Margin = new Padding(6, 49, 64, 49);
            lblApuntes.Name = "lblApuntes";
            lblApuntes.Size = new Size(0, 21);
            lblApuntes.TabIndex = 13;
            // 
            // linkLblCuentas
            // 
            linkLblCuentas.AutoSize = true;
            linkLblCuentas.Location = new Point(426, 49);
            linkLblCuentas.Margin = new Padding(6, 49, 64, 49);
            linkLblCuentas.Name = "linkLblCuentas";
            linkLblCuentas.Size = new Size(0, 21);
            linkLblCuentas.TabIndex = 12;
            linkLblCuentas.LinkClicked += linkLblCuentas_LinkClicked;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.BackColor = Color.FromArgb(8, 138, 100);
            btnEditar.Dock = DockStyle.Bottom;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(0, 855);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(1286, 55);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar Cliente";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // flpMultimedia
            // 
            flpMultimedia.AutoScroll = true;
            flpMultimedia.Dock = DockStyle.Fill;
            flpMultimedia.Location = new Point(553, 28);
            flpMultimedia.Margin = new Padding(4);
            flpMultimedia.Name = "flpMultimedia";
            flpMultimedia.Size = new Size(733, 827);
            flpMultimedia.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(553, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 0;
            label1.Text = "Archivos multimedia del cliente:";
            // 
            // FrmVerDetalleCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 910);
            Controls.Add(flpMultimedia);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnEditar);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmVerDetalleCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVerPagos";
            Load += FrmVerClientes_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCedula;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCorreo;
        private FlowLayoutPanel flpMultimedia;
        private Label label1;
        private LinkLabel linkLblCuentas;
        private Button btnEditar;
        private Label lblApuntes;
    }
}