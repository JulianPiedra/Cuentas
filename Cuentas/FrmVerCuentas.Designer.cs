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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgvCuentas = new DataGridView();
            Cuenta = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Cuotas = new DataGridViewTextBoxColumn();
            Canceladas = new DataGridViewTextBoxColumn();
            SiguientePago = new DataGridViewTextBoxColumn();
            Multa = new DataGridViewButtonColumn();
            VerPagos = new DataGridViewButtonColumn();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panel1 = new Panel();
            cmbSemanal = new ComboBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCuentas.Columns.AddRange(new DataGridViewColumn[] { Cuenta, Cliente, Monto, Cuotas, Canceladas, SiguientePago, Multa, VerPagos });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvCuentas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvCuentas.Dock = DockStyle.Fill;
            DgvCuentas.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvCuentas.Location = new Point(0, 66);
            DgvCuentas.Name = "DgvCuentas";
            DgvCuentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvCuentas.Size = new Size(800, 384);
            DgvCuentas.TabIndex = 0;
            // 
            // Cuenta
            // 
            Cuenta.HeaderText = "Cuenta";
            Cuenta.Name = "Cuenta";
            Cuenta.ReadOnly = true;
            Cuenta.Visible = false;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
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
            // Multa
            // 
            Multa.HeaderText = "Multa";
            Multa.Name = "Multa";
            Multa.ReadOnly = true;
            Multa.Resizable = DataGridViewTriState.True;
            Multa.SortMode = DataGridViewColumnSortMode.Automatic;
            Multa.Text = "Multar Cuenta";
            Multa.UseColumnTextForButtonValue = true;
            // 
            // VerPagos
            // 
            VerPagos.HeaderText = "Pagos";
            VerPagos.Name = "VerPagos";
            VerPagos.ReadOnly = true;
            VerPagos.Text = "Ver Pagos";
            VerPagos.UseColumnTextForButtonValue = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(0, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(561, 29);
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
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cmbSemanal);
            panel1.Controls.Add(lblBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 4;
            // 
            // cmbSemanal
            // 
            cmbSemanal.Dock = DockStyle.Right;
            cmbSemanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemanal.Font = new Font("Segoe UI", 12F);
            cmbSemanal.FormattingEnabled = true;
            cmbSemanal.Items.AddRange(new object[] { "Seleccione un día de filtrado", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo", "15", "30" });
            cmbSemanal.Location = new Point(561, 21);
            cmbSemanal.Name = "cmbSemanal";
            cmbSemanal.Size = new Size(239, 29);
            cmbSemanal.TabIndex = 7;
            cmbSemanal.SelectedIndexChanged += cmbSemanal_SelectedIndexChanged;
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
            Load += FrmVerCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCuentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvCuentas;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel panel1;
        private ComboBox cmbSemanal;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Cuotas;
        private DataGridViewTextBoxColumn Canceladas;
        private DataGridViewTextBoxColumn SiguientePago;
        private DataGridViewButtonColumn Multa;
        private DataGridViewButtonColumn VerPagos;
    }
}