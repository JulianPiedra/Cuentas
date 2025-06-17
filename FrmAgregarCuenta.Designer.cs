namespace Cuentas
{
    partial class FrmAgregarCuenta
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
            lblCuenta = new Label();
            txtCuenta = new TextBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            lblTipoPago = new Label();
            RbSemanal = new RadioButton();
            RbQuincenal = new RadioButton();
            RbMensual = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Dock = DockStyle.Top;
            lblCuenta.Location = new Point(0, 0);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(118, 15);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "Cuenta a nombre de:";
            // 
            // txtCuenta
            // 
            txtCuenta.Dock = DockStyle.Top;
            txtCuenta.Location = new Point(0, 15);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(800, 23);
            txtCuenta.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Dock = DockStyle.Top;
            txtMonto.Location = new Point(0, 53);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(800, 23);
            txtMonto.TabIndex = 2;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Dock = DockStyle.Top;
            lblMonto.Location = new Point(0, 38);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(115, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto de préstamo:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Dock = DockStyle.Top;
            lblTipoPago.Location = new Point(0, 76);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(80, 15);
            lblTipoPago.TabIndex = 4;
            lblTipoPago.Text = "Tipo de pago:";
            // 
            // RbSemanal
            // 
            RbSemanal.AutoSize = true;
            RbSemanal.Dock = DockStyle.Left;
            RbSemanal.Location = new Point(0, 91);
            RbSemanal.MaximumSize = new Size(0, 19);
            RbSemanal.Name = "RbSemanal";
            RbSemanal.Size = new Size(70, 19);
            RbSemanal.TabIndex = 3;
            RbSemanal.TabStop = true;
            RbSemanal.Text = "Semanal";
            RbSemanal.UseVisualStyleBackColor = true;
            RbSemanal.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // RbQuincenal
            // 
            RbQuincenal.AutoSize = true;
            RbQuincenal.Dock = DockStyle.Left;
            RbQuincenal.Location = new Point(70, 91);
            RbQuincenal.MaximumSize = new Size(0, 19);
            RbQuincenal.Name = "RbQuincenal";
            RbQuincenal.Size = new Size(79, 19);
            RbQuincenal.TabIndex = 4;
            RbQuincenal.TabStop = true;
            RbQuincenal.Text = "Quincenal";
            RbQuincenal.UseVisualStyleBackColor = true;
            RbQuincenal.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // RbMensual
            // 
            RbMensual.AutoSize = true;
            RbMensual.Dock = DockStyle.Left;
            RbMensual.Location = new Point(149, 91);
            RbMensual.MaximumSize = new Size(0, 19);
            RbMensual.Name = "RbMensual";
            RbMensual.Size = new Size(70, 19);
            RbMensual.TabIndex = 5;
            RbMensual.TabStop = true;
            RbMensual.Text = "Mensual";
            RbMensual.UseVisualStyleBackColor = true;
            RbMensual.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 267);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // FrmAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(RbMensual);
            Controls.Add(RbQuincenal);
            Controls.Add(RbSemanal);
            Controls.Add(lblTipoPago);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtCuenta);
            Controls.Add(lblCuenta);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar cuenta";
            WindowState = FormWindowState.Maximized;
            Load += FrmAgregarCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private TextBox txtCuenta;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblTipoPago;
        private RadioButton RbSemanal;
        private RadioButton RbQuincenal;
        private RadioButton RbMensual;
        private Label label1;
    }
}