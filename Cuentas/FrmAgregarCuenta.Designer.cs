using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnCrearCuenta = new Button();
            DgvPagos = new DataGridView();
            Pagos = new DataGridViewTextBoxColumn();
            Pagado = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            pnlTipos = new Panel();
            cmbTipoCuenta = new ComboBox();
            cmbTipoPago = new ComboBox();
            panel2 = new Panel();
            lblTipoCuenta = new Label();
            lblTipoPago = new Label();
            txtMontoCuotas = new TextBox();
            lblMontoCuotas = new Label();
            txtCantCuotas = new TextBox();
            lblNumCuotas = new Label();
            pnlFrecuencia = new Panel();
            dtpFecha = new DateTimePicker();
            cmbSemanal = new ComboBox();
            lblFecha = new Label();
            pnlRadios = new Panel();
            cbIniciado = new CheckBox();
            RbMensual = new RadioButton();
            RbQuincenal = new RadioButton();
            RbSemanal = new RadioButton();
            lblFrecuencia = new Label();
            txtMontoCuenta = new TextBox();
            lblMonto = new Label();
            cmbCuenta = new ComboBox();
            lblCuenta = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvPagos).BeginInit();
            panel1.SuspendLayout();
            pnlTipos.SuspendLayout();
            panel2.SuspendLayout();
            pnlFrecuencia.SuspendLayout();
            pnlRadios.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FromArgb(8, 138, 100);
            btnCrearCuenta.Dock = DockStyle.Bottom;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.Location = new Point(0, 542);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.RightToLeft = RightToLeft.Yes;
            btnCrearCuenta.Size = new Size(1029, 88);
            btnCrearCuenta.TabIndex = 12;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // DgvPagos
            // 
            DgvPagos.AllowUserToAddRows = false;
            DgvPagos.AllowUserToDeleteRows = false;
            DgvPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(161, 212, 197);
            DgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagos.Columns.AddRange(new DataGridViewColumn[] { Pagos, Pagado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvPagos.DefaultCellStyle = dataGridViewCellStyle3;
            DgvPagos.Dock = DockStyle.Right;
            DgvPagos.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvPagos.EnableHeadersVisualStyles = false;
            DgvPagos.Location = new Point(610, 0);
            DgvPagos.Name = "DgvPagos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvPagos.RowHeadersVisible = false;
            DgvPagos.Size = new Size(419, 542);
            DgvPagos.TabIndex = 15;
            DgvPagos.Visible = false;
            DgvPagos.CellContentClick += DgvPagos_CellContentClick;
            // 
            // Pagos
            // 
            Pagos.HeaderText = "Fecha del pago";
            Pagos.Name = "Pagos";
            Pagos.ReadOnly = true;
            Pagos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Pagado
            // 
            Pagado.HeaderText = "Pago hecho";
            Pagado.Name = "Pagado";
            Pagado.Resizable = DataGridViewTriState.True;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlTipos);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtMontoCuotas);
            panel1.Controls.Add(lblMontoCuotas);
            panel1.Controls.Add(txtCantCuotas);
            panel1.Controls.Add(lblNumCuotas);
            panel1.Controls.Add(pnlFrecuencia);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(pnlRadios);
            panel1.Controls.Add(lblFrecuencia);
            panel1.Controls.Add(txtMontoCuenta);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(cmbCuenta);
            panel1.Controls.Add(lblCuenta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 20, 50, 0);
            panel1.Size = new Size(610, 542);
            panel1.TabIndex = 16;
            // 
            // pnlTipos
            // 
            pnlTipos.Controls.Add(cmbTipoCuenta);
            pnlTipos.Controls.Add(cmbTipoPago);
            pnlTipos.Dock = DockStyle.Top;
            pnlTipos.Location = new Point(20, 354);
            pnlTipos.Name = "pnlTipos";
            pnlTipos.Size = new Size(540, 36);
            pnlTipos.TabIndex = 38;
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoCuenta.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoCuenta.Dock = DockStyle.Right;
            cmbTipoCuenta.Font = new Font("Segoe UI", 12F);
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Location = new Point(260, 0);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(280, 29);
            cmbTipoCuenta.TabIndex = 34;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoPago.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoPago.Dock = DockStyle.Left;
            cmbTipoPago.Font = new Font("Segoe UI", 12F);
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(0, 0);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(280, 29);
            cmbTipoPago.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTipoCuenta);
            panel2.Controls.Add(lblTipoPago);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(20, 326);
            panel2.Margin = new Padding(3, 50, 3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 185, 0);
            panel2.Size = new Size(540, 28);
            panel2.TabIndex = 36;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoEllipsis = true;
            lblTipoCuenta.Dock = DockStyle.Left;
            lblTipoCuenta.Font = new Font("Segoe UI", 12F);
            lblTipoCuenta.Location = new Point(0, 0);
            lblTipoCuenta.Margin = new Padding(50, 0, 3, 0);
            lblTipoCuenta.MaximumSize = new Size(0, 21);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(205, 21);
            lblTipoCuenta.TabIndex = 35;
            lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Dock = DockStyle.Right;
            lblTipoPago.Font = new Font("Segoe UI", 12F);
            lblTipoPago.Location = new Point(256, 0);
            lblTipoPago.MaximumSize = new Size(0, 21);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(99, 21);
            lblTipoPago.TabIndex = 34;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // txtMontoCuotas
            // 
            txtMontoCuotas.Dock = DockStyle.Top;
            txtMontoCuotas.Enabled = false;
            txtMontoCuotas.Font = new Font("Segoe UI", 12F);
            txtMontoCuotas.Location = new Point(20, 297);
            txtMontoCuotas.Name = "txtMontoCuotas";
            txtMontoCuotas.Size = new Size(540, 29);
            txtMontoCuotas.TabIndex = 24;
            txtMontoCuotas.TextChanged += Control_ValueChanged;
            // 
            // lblMontoCuotas
            // 
            lblMontoCuotas.AutoSize = true;
            lblMontoCuotas.Dock = DockStyle.Top;
            lblMontoCuotas.Font = new Font("Segoe UI", 12F);
            lblMontoCuotas.Location = new Point(20, 276);
            lblMontoCuotas.Name = "lblMontoCuotas";
            lblMontoCuotas.Size = new Size(155, 21);
            lblMontoCuotas.TabIndex = 23;
            lblMontoCuotas.Text = "Monto de cada cuota";
            // 
            // txtCantCuotas
            // 
            txtCantCuotas.Dock = DockStyle.Top;
            txtCantCuotas.Font = new Font("Segoe UI", 12F);
            txtCantCuotas.Location = new Point(20, 247);
            txtCantCuotas.Name = "txtCantCuotas";
            txtCantCuotas.Size = new Size(540, 29);
            txtCantCuotas.TabIndex = 25;
            txtCantCuotas.TextChanged += TextBox_TextChanged;
            txtCantCuotas.KeyPress += txtChanged_KeyPress;
            // 
            // lblNumCuotas
            // 
            lblNumCuotas.AutoSize = true;
            lblNumCuotas.Dock = DockStyle.Top;
            lblNumCuotas.Font = new Font("Segoe UI", 12F);
            lblNumCuotas.Location = new Point(20, 226);
            lblNumCuotas.Name = "lblNumCuotas";
            lblNumCuotas.Size = new Size(142, 21);
            lblNumCuotas.TabIndex = 21;
            lblNumCuotas.Text = "Cantidad de cuotas";
            // 
            // pnlFrecuencia
            // 
            pnlFrecuencia.Controls.Add(dtpFecha);
            pnlFrecuencia.Controls.Add(cmbSemanal);
            pnlFrecuencia.Dock = DockStyle.Top;
            pnlFrecuencia.Font = new Font("Segoe UI", 12F);
            pnlFrecuencia.Location = new Point(20, 195);
            pnlFrecuencia.Name = "pnlFrecuencia";
            pnlFrecuencia.Size = new Size(540, 31);
            pnlFrecuencia.TabIndex = 15;
            // 
            // dtpFecha
            // 
            dtpFecha.Checked = false;
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Dock = DockStyle.Top;
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(0, 29);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(540, 29);
            dtpFecha.TabIndex = 7;
            dtpFecha.Value = new DateTime(2025, 8, 21, 0, 0, 0, 0);
            dtpFecha.Visible = false;
            dtpFecha.ValueChanged += Control_ValueChanged;
            // 
            // cmbSemanal
            // 
            cmbSemanal.Dock = DockStyle.Top;
            cmbSemanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemanal.Font = new Font("Segoe UI", 12F);
            cmbSemanal.FormattingEnabled = true;
            cmbSemanal.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            cmbSemanal.Location = new Point(0, 0);
            cmbSemanal.Name = "cmbSemanal";
            cmbSemanal.Size = new Size(540, 29);
            cmbSemanal.TabIndex = 6;
            cmbSemanal.SelectedIndexChanged += Control_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Dock = DockStyle.Top;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(20, 174);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(110, 21);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha de pago";
            // 
            // pnlRadios
            // 
            pnlRadios.Controls.Add(cbIniciado);
            pnlRadios.Controls.Add(RbMensual);
            pnlRadios.Controls.Add(RbQuincenal);
            pnlRadios.Controls.Add(RbSemanal);
            pnlRadios.Dock = DockStyle.Top;
            pnlRadios.Font = new Font("Segoe UI", 12F);
            pnlRadios.Location = new Point(20, 141);
            pnlRadios.Name = "pnlRadios";
            pnlRadios.Size = new Size(540, 33);
            pnlRadios.TabIndex = 19;
            // 
            // cbIniciado
            // 
            cbIniciado.AutoSize = true;
            cbIniciado.Dock = DockStyle.Right;
            cbIniciado.Font = new Font("Segoe UI", 12F);
            cbIniciado.Location = new Point(311, 0);
            cbIniciado.Name = "cbIniciado";
            cbIniciado.Size = new Size(229, 33);
            cbIniciado.TabIndex = 6;
            cbIniciado.Text = "Cuenta en curso o ya pagada";
            cbIniciado.UseVisualStyleBackColor = true;
            cbIniciado.CheckedChanged += cbIniciado_CheckedChanged;
            // 
            // RbMensual
            // 
            RbMensual.AutoSize = true;
            RbMensual.Dock = DockStyle.Left;
            RbMensual.Font = new Font("Segoe UI", 12F);
            RbMensual.Location = new Point(186, 0);
            RbMensual.Name = "RbMensual";
            RbMensual.Size = new Size(87, 33);
            RbMensual.TabIndex = 5;
            RbMensual.TabStop = true;
            RbMensual.Text = "Mensual";
            RbMensual.UseVisualStyleBackColor = true;
            RbMensual.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // RbQuincenal
            // 
            RbQuincenal.AutoSize = true;
            RbQuincenal.Dock = DockStyle.Left;
            RbQuincenal.Font = new Font("Segoe UI", 12F);
            RbQuincenal.Location = new Point(88, 0);
            RbQuincenal.Name = "RbQuincenal";
            RbQuincenal.Size = new Size(98, 33);
            RbQuincenal.TabIndex = 4;
            RbQuincenal.TabStop = true;
            RbQuincenal.Text = "Quincenal";
            RbQuincenal.UseVisualStyleBackColor = true;
            RbQuincenal.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // RbSemanal
            // 
            RbSemanal.AutoSize = true;
            RbSemanal.Checked = true;
            RbSemanal.Dock = DockStyle.Left;
            RbSemanal.Font = new Font("Segoe UI", 12F);
            RbSemanal.Location = new Point(0, 0);
            RbSemanal.Name = "RbSemanal";
            RbSemanal.Size = new Size(88, 33);
            RbSemanal.TabIndex = 3;
            RbSemanal.TabStop = true;
            RbSemanal.Text = "Semanal";
            RbSemanal.UseVisualStyleBackColor = true;
            RbSemanal.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // lblFrecuencia
            // 
            lblFrecuencia.AutoSize = true;
            lblFrecuencia.Dock = DockStyle.Top;
            lblFrecuencia.Font = new Font("Segoe UI", 12F);
            lblFrecuencia.Location = new Point(20, 120);
            lblFrecuencia.Name = "lblFrecuencia";
            lblFrecuencia.Size = new Size(148, 21);
            lblFrecuencia.TabIndex = 20;
            lblFrecuencia.Text = "Frecuencia del pago";
            // 
            // txtMontoCuenta
            // 
            txtMontoCuenta.Dock = DockStyle.Top;
            txtMontoCuenta.Font = new Font("Segoe UI", 12F);
            txtMontoCuenta.Location = new Point(20, 91);
            txtMontoCuenta.Name = "txtMontoCuenta";
            txtMontoCuenta.Size = new Size(540, 29);
            txtMontoCuenta.TabIndex = 22;
            txtMontoCuenta.TextChanged += TextBox_TextChanged;
            txtMontoCuenta.KeyPress += txtChanged_KeyPress;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Dock = DockStyle.Top;
            lblMonto.Font = new Font("Segoe UI", 12F);
            lblMonto.Location = new Point(20, 70);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(143, 21);
            lblMonto.TabIndex = 39;
            lblMonto.Text = "Monto de la cuenta";
            // 
            // cmbCuenta
            // 
            cmbCuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCuenta.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCuenta.Dock = DockStyle.Top;
            cmbCuenta.Font = new Font("Segoe UI", 12F);
            cmbCuenta.FormattingEnabled = true;
            cmbCuenta.Location = new Point(20, 41);
            cmbCuenta.Name = "cmbCuenta";
            cmbCuenta.Size = new Size(540, 29);
            cmbCuenta.TabIndex = 26;
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Dock = DockStyle.Top;
            lblCuenta.Font = new Font("Segoe UI", 12F);
            lblCuenta.Location = new Point(20, 20);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(151, 21);
            lblCuenta.TabIndex = 18;
            lblCuenta.Text = "Cuenta a nombre de";
            // 
            // FrmAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1029, 630);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(DgvPagos);
            Controls.Add(btnCrearCuenta);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cuenta";
            WindowState = FormWindowState.Maximized;
            Load += FrmAgregarCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPagos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTipos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlFrecuencia.ResumeLayout(false);
            pnlRadios.ResumeLayout(false);
            pnlRadios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCrearCuenta;
        private DataGridView DgvPagos;
        private DataGridViewTextBoxColumn Pagos;
        private DataGridViewCheckBoxColumn Pagado;
        private Panel panel1;
        private TextBox txtMontoCuotas;
        private Label lblMontoCuotas;
        private TextBox txtCantCuotas;
        private Label lblNumCuotas;
        private Panel pnlFrecuencia;
        private DateTimePicker dtpFecha;
        private ComboBox cmbSemanal;
        private Label lblFecha;
        private Panel pnlRadios;
        private CheckBox cbIniciado;
        private RadioButton RbMensual;
        private RadioButton RbQuincenal;
        private RadioButton RbSemanal;
        private Label lblFrecuencia;
        private TextBox txtMontoCuenta;
        private Label lblMonto;
        private ComboBox cmbCuenta;
        private Label lblCuenta;
        private Label lblTipoPago;
        private Label lblTipoCuenta;
        private Panel pnlTipos;
        private ComboBox cmbTipoCuenta;
        private ComboBox cmbTipoPago;
        private Panel panel2;
    }
}