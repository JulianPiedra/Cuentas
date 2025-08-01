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
            flpMultimedia = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblCedula);
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Controls.Add(lblTelefono);
            flowLayoutPanel1.Controls.Add(lblDireccion);
            flowLayoutPanel1.Controls.Add(lblCorreo);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(284, 650);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 12F);
            lblCedula.Location = new Point(5, 35);
            lblCedula.Margin = new Padding(5, 35, 5, 35);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(0, 21);
            lblCedula.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(15, 35);
            lblNombre.Margin = new Padding(5, 35, 5, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(25, 35);
            lblTelefono.Margin = new Padding(5, 35, 5, 35);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(0, 21);
            lblTelefono.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(35, 35);
            lblDireccion.Margin = new Padding(5, 35, 5, 35);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 21);
            lblDireccion.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(45, 35);
            lblCorreo.Margin = new Padding(5, 35, 5, 35);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(0, 21);
            lblCorreo.TabIndex = 10;
            // 
            // flpMultimedia
            // 
            flpMultimedia.AutoScroll = true;
            flpMultimedia.Dock = DockStyle.Fill;
            flpMultimedia.Location = new Point(284, 15);
            flpMultimedia.Name = "flpMultimedia";
            flpMultimedia.Size = new Size(716, 635);
            flpMultimedia.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(284, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 0;
            label1.Text = "Archivos multimedia del cliente:";
            // 
            // FrmVerDetalleCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(flpMultimedia);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmVerDetalleCliente";
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
    }
}