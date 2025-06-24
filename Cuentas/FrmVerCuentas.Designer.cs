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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
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
            DgvCuentas.Dock = DockStyle.Fill;
            DgvCuentas.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvCuentas.Location = new Point(0, 38);
            DgvCuentas.Name = "DgvCuentas";
            DgvCuentas.ReadOnly = true;
            DgvCuentas.Size = new Size(800, 412);
            DgvCuentas.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Dock = DockStyle.Top;
            txtBuscar.Location = new Point(0, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(800, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Dock = DockStyle.Top;
            lblBuscar.Location = new Point(0, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(86, 15);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar cuentas";
            // 
            // FrmVerCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(DgvCuentas);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmVerCuentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver cuentas";
            WindowState = FormWindowState.Maximized;
            Activated += FrmVerCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCuentas;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}