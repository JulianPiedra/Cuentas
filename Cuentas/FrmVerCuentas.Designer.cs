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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DgvCuentas = new DataGridView();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            cbPagosHoy = new CheckBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvCuentas
            // 
            DgvCuentas.AllowUserToAddRows = false;
            DgvCuentas.AllowUserToDeleteRows = false;
            DgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DgvCuentas.DefaultCellStyle = dataGridViewCellStyle5;
            DgvCuentas.Dock = DockStyle.Fill;
            DgvCuentas.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvCuentas.Location = new Point(0, 52);
            DgvCuentas.Name = "DgvCuentas";
            DgvCuentas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DgvCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DgvCuentas.Size = new Size(800, 398);
            DgvCuentas.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(0, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(629, 29);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Dock = DockStyle.Top;
            lblBuscar.Font = new Font("Segoe UI", 12F);
            lblBuscar.Location = new Point(0, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(113, 21);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar cuentas";
            // 
            // cbPagosHoy
            // 
            cbPagosHoy.AutoSize = true;
            cbPagosHoy.Dock = DockStyle.Right;
            cbPagosHoy.Font = new Font("Segoe UI", 12F);
            cbPagosHoy.Location = new Point(629, 21);
            cbPagosHoy.MaximumSize = new Size(0, 29);
            cbPagosHoy.Name = "cbPagosHoy";
            cbPagosHoy.Padding = new Padding(50, 0, 0, 0);
            cbPagosHoy.Size = new Size(171, 29);
            cbPagosHoy.TabIndex = 3;
            cbPagosHoy.Text = "Pagos de hoy";
            cbPagosHoy.UseVisualStyleBackColor = true;
            cbPagosHoy.CheckedChanged += cbPagosHoy_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cbPagosHoy);
            panel1.Controls.Add(lblBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 4;
            // 
            // FrmVerCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(DgvCuentas);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvCuentas;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private CheckBox cbPagosHoy;
        private Panel panel1;
    }
}