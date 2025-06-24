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
            lblCedula = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            FileDialog = new OpenFileDialog();
            btnMultimedia = new Button();
            flpMultimedia = new FlowLayoutPanel();
            btnAgregar = new Button();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Dock = DockStyle.Top;
            lblCedula.Font = new Font("Segoe UI", 12F);
            lblCedula.Location = new Point(0, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(135, 21);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cédula del cliente:";
            // 
            // txtCedula
            // 
            txtCedula.Dock = DockStyle.Top;
            txtCedula.Font = new Font("Segoe UI", 12F);
            txtCedula.Location = new Point(0, 21);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(800, 29);
            txtCedula.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Dock = DockStyle.Top;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(0, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(800, 29);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(0, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(145, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del cliente:";
            // 
            // txtCorreo
            // 
            txtCorreo.Dock = DockStyle.Top;
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(0, 121);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(800, 29);
            txtCorreo.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Dock = DockStyle.Top;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(0, 100);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 21);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo del cliente:";
            // 
            // txtTelefono
            // 
            txtTelefono.Dock = DockStyle.Top;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(0, 171);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(800, 29);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Top;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(0, 150);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(145, 21);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono del cliente:";
            // 
            // txtDireccion
            // 
            txtDireccion.Dock = DockStyle.Top;
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(0, 221);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(800, 29);
            txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Top;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(0, 200);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(152, 21);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección del cliente:";
            // 
            // FileDialog
            // 
            FileDialog.Multiselect = true;
            FileDialog.FileOk += FileDialog_FileOk;
            // 
            // btnMultimedia
            // 
            btnMultimedia.AutoSize = true;
            btnMultimedia.Dock = DockStyle.Top;
            btnMultimedia.Location = new Point(0, 0);
            btnMultimedia.MaximumSize = new Size(100, 50);
            btnMultimedia.Name = "btnMultimedia";
            btnMultimedia.Size = new Size(100, 50);
            btnMultimedia.TabIndex = 10;
            btnMultimedia.Text = "Agregar multimedia";
            btnMultimedia.UseVisualStyleBackColor = true;
            btnMultimedia.Click += btnMultimedia_Click;
            // 
            // flpMultimedia
            // 
            flpMultimedia.AutoScroll = true;
            flpMultimedia.Dock = DockStyle.Fill;
            flpMultimedia.Location = new Point(0, 250);
            flpMultimedia.Name = "flpMultimedia";
            flpMultimedia.Size = new Size(700, 177);
            flpMultimedia.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Right;
            btnAgregar.Location = new Point(0, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 127);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnMultimedia);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(700, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 177);
            panel1.TabIndex = 13;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 23);
            progressBar1.TabIndex = 0;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(flpMultimedia);
            Controls.Add(panel1);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCedula;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private OpenFileDialog FileDialog;
        private Button btnMultimedia;
        private FlowLayoutPanel flpMultimedia;
        private Button btnAgregar;
        private Panel panel1;
        private ProgressBar progressBar1;
    }
}