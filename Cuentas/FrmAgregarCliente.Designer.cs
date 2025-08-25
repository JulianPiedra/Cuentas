namespace Cuentas
{
    partial class FrmAgregarCliente
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
            FileDialog = new OpenFileDialog();
            btnMultimedia = new Button();
            panel2 = new Panel();
            txtApuntes = new TextBox();
            lblApuntes = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            btnAgregar = new Button();
            flpMultimedia = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FileDialog
            // 
            FileDialog.Multiselect = true;
            FileDialog.FileOk += FileDialog_FileOk;
            // 
            // btnMultimedia
            // 
            btnMultimedia.AutoSize = true;
            btnMultimedia.BackColor = Color.FromArgb(8, 138, 100);
            btnMultimedia.Cursor = Cursors.Hand;
            btnMultimedia.FlatAppearance.BorderColor = Color.White;
            btnMultimedia.FlatAppearance.BorderSize = 0;
            btnMultimedia.FlatStyle = FlatStyle.Flat;
            btnMultimedia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultimedia.ForeColor = Color.White;
            btnMultimedia.Location = new Point(770, 386);
            btnMultimedia.Margin = new Padding(4);
            btnMultimedia.Name = "btnMultimedia";
            btnMultimedia.Size = new Size(174, 88);
            btnMultimedia.TabIndex = 10;
            btnMultimedia.Text = "Agregar multimedia";
            btnMultimedia.UseVisualStyleBackColor = false;
            btnMultimedia.Click += btnMultimedia_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnMultimedia);
            panel2.Controls.Add(txtApuntes);
            panel2.Controls.Add(lblApuntes);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(lblDireccion);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(lblCorreo);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(lblCedula);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 542);
            panel2.TabIndex = 16;
            // 
            // txtApuntes
            // 
            txtApuntes.BackColor = SystemColors.Control;
            txtApuntes.Dock = DockStyle.Top;
            txtApuntes.Font = new Font("Segoe UI", 12F);
            txtApuntes.ForeColor = SystemColors.WindowText;
            txtApuntes.Location = new Point(0, 271);
            txtApuntes.Margin = new Padding(4);
            txtApuntes.Multiline = true;
            txtApuntes.Name = "txtApuntes";
            txtApuntes.Size = new Size(950, 107);
            txtApuntes.TabIndex = 28;
            // 
            // lblApuntes
            // 
            lblApuntes.AutoSize = true;
            lblApuntes.Dock = DockStyle.Top;
            lblApuntes.Font = new Font("Segoe UI", 12F);
            lblApuntes.Location = new Point(0, 250);
            lblApuntes.Margin = new Padding(4, 0, 4, 0);
            lblApuntes.Name = "lblApuntes";
            lblApuntes.Size = new Size(175, 21);
            lblApuntes.TabIndex = 27;
            lblApuntes.Text = "Apuntes sobre el cliente";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.Control;
            txtDireccion.Dock = DockStyle.Top;
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.ForeColor = SystemColors.WindowText;
            txtDireccion.Location = new Point(0, 221);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(950, 29);
            txtDireccion.TabIndex = 25;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Top;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(0, 200);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(149, 21);
            lblDireccion.TabIndex = 24;
            lblDireccion.Text = "Dirección del cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.Control;
            txtTelefono.Dock = DockStyle.Top;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.ForeColor = SystemColors.WindowText;
            txtTelefono.Location = new Point(0, 171);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(950, 29);
            txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Top;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(0, 150);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(142, 21);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Teléfono del cliente";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Control;
            txtCorreo.Dock = DockStyle.Top;
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.ForeColor = SystemColors.WindowText;
            txtCorreo.Location = new Point(0, 121);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(950, 29);
            txtCorreo.TabIndex = 21;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Dock = DockStyle.Top;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(0, 100);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(132, 21);
            lblCorreo.TabIndex = 20;
            lblCorreo.Text = "Correo del cliente";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Control;
            txtNombre.Dock = DockStyle.Top;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(0, 71);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(950, 29);
            txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(0, 50);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 21);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre del cliente";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.Control;
            txtCedula.Dock = DockStyle.Top;
            txtCedula.Font = new Font("Segoe UI", 12F);
            txtCedula.ForeColor = SystemColors.WindowText;
            txtCedula.Location = new Point(0, 21);
            txtCedula.Margin = new Padding(4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(950, 29);
            txtCedula.TabIndex = 17;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Dock = DockStyle.Top;
            lblCedula.Font = new Font("Segoe UI", 12F);
            lblCedula.Location = new Point(0, 0);
            lblCedula.Margin = new Padding(4, 0, 4, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(132, 21);
            lblCedula.TabIndex = 16;
            lblCedula.Text = "Cédula del cliente";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(8, 138, 100);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Dock = DockStyle.Bottom;
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 542);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(1029, 88);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar cliente";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // flpMultimedia
            // 
            flpMultimedia.AutoScroll = true;
            flpMultimedia.BackColor = Color.White;
            flpMultimedia.BorderStyle = BorderStyle.Fixed3D;
            flpMultimedia.Dock = DockStyle.Fill;
            flpMultimedia.Font = new Font("Segoe UI", 12F);
            flpMultimedia.Location = new Point(954, 0);
            flpMultimedia.Margin = new Padding(4);
            flpMultimedia.Name = "flpMultimedia";
            flpMultimedia.Size = new Size(75, 542);
            flpMultimedia.TabIndex = 27;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            ControlBox = false;
            Controls.Add(flpMultimedia);
            Controls.Add(panel2);
            Controls.Add(btnAgregar);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog FileDialog;
        private Button btnMultimedia;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtApuntes;
        private Label lblApuntes;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCedula;
        private Label lblCedula;
        private Button btnAgregar;
        private FlowLayoutPanel flpMultimedia;
    }
}