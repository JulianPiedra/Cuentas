namespace Cuentas
{
    partial class FrmVerCuentas
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
            DgvCuentas = new DataGridView();
            Cuenta = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Cuotas = new DataGridViewTextBoxColumn();
            Canceladas = new DataGridViewTextBoxColumn();
            SiguientePago = new DataGridViewTextBoxColumn();
            AgregarMonto = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // DgvCuentas
            // 
            DgvCuentas.AllowUserToAddRows = false;
            DgvCuentas.AllowUserToDeleteRows = false;
            DgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCuentas.Columns.AddRange(new DataGridViewColumn[] { Cuenta, Monto, Cuotas, Canceladas, SiguientePago, AgregarMonto });
            DgvCuentas.Dock = DockStyle.Fill;
            DgvCuentas.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvCuentas.Location = new Point(0, 0);
            DgvCuentas.Name = "DgvCuentas";
            DgvCuentas.ReadOnly = true;
            DgvCuentas.Size = new Size(800, 450);
            DgvCuentas.TabIndex = 0;
            // 
            // Cuenta
            // 
            Cuenta.HeaderText = "Cuenta";
            Cuenta.Name = "Cuenta";
            Cuenta.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Cuotas
            // 
            Cuotas.HeaderText = "Cuotas";
            Cuotas.Name = "Cuotas";
            Cuotas.ReadOnly = true;
            // 
            // Canceladas
            // 
            Canceladas.HeaderText = "Canceladas";
            Canceladas.Name = "Canceladas";
            Canceladas.ReadOnly = true;
            // 
            // SiguientePago
            // 
            SiguientePago.HeaderText = "Siguiente Pago";
            SiguientePago.Name = "SiguientePago";
            SiguientePago.ReadOnly = true;
            // 
            // AgregarMonto
            // 
            AgregarMonto.HeaderText = "AgregarMonto";
            AgregarMonto.Name = "AgregarMonto";
            AgregarMonto.ReadOnly = true;
            // 
            // FrmVerCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(DgvCuentas);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmVerCuentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver cuentas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVerCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvCuentas;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Cuotas;
        private DataGridViewTextBoxColumn Canceladas;
        private DataGridViewTextBoxColumn SiguientePago;
        private DataGridViewButtonColumn AgregarMonto;
    }
}