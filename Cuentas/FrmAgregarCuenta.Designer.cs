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
            lblCuenta = new Label();
            lblMonto = new Label();
            lblTipoPago = new Label();
            pnlRadios = new Panel();
            cbIniciado = new CheckBox();
            RbMensual = new RadioButton();
            RbQuincenal = new RadioButton();
            RbSemanal = new RadioButton();
            lblFrecuencia = new Label();
            cmbSemanal = new ComboBox();
            dtpFecha = new DateTimePicker();
            pnlFrecuencia = new Panel();
            lblNumCuotas = new Label();
            lblMontoCuotas = new Label();
            txtMontoCuotas = new TextBox();
            btnCrearCuenta = new Button();
            txtMontoCuenta = new TextBox();
            txtCantCuotas = new TextBox();
            cmbCuenta = new ComboBox();
            DgvPagos = new DataGridView();
            Pagos = new DataGridViewTextBoxColumn();
            Pagado = new DataGridViewCheckBoxColumn();
            pnlRadios.SuspendLayout();
            pnlFrecuencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPagos).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Dock = DockStyle.Top;
            lblCuenta.Font = new Font("Segoe UI", 12F);
            lblCuenta.Location = new Point(0, 0);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(154, 21);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "Cuenta a nombre de:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Dock = DockStyle.Top;
            lblMonto.Font = new Font("Segoe UI", 12F);
            lblMonto.Location = new Point(0, 50);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(150, 21);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto de préstamo:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Dock = DockStyle.Top;
            lblTipoPago.Font = new Font("Segoe UI", 12F);
            lblTipoPago.Location = new Point(0, 100);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(103, 21);
            lblTipoPago.TabIndex = 4;
            lblTipoPago.Text = "Tipo de pago:";
            // 
            // pnlRadios
            // 
            pnlRadios.Controls.Add(cbIniciado);
            pnlRadios.Controls.Add(RbMensual);
            pnlRadios.Controls.Add(RbQuincenal);
            pnlRadios.Controls.Add(RbSemanal);
            pnlRadios.Dock = DockStyle.Top;
            pnlRadios.Font = new Font("Segoe UI", 12F);
            pnlRadios.Location = new Point(0, 121);
            pnlRadios.Name = "pnlRadios";
            pnlRadios.Size = new Size(800, 33);
            pnlRadios.TabIndex = 3;
            // 
            // cbIniciado
            // 
            cbIniciado.AutoSize = true;
            cbIniciado.Dock = DockStyle.Right;
            cbIniciado.Font = new Font("Segoe UI", 12F);
            cbIniciado.Location = new Point(571, 0);
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
            lblFrecuencia.Location = new Point(0, 154);
            lblFrecuencia.Name = "lblFrecuencia";
            lblFrecuencia.Size = new Size(110, 21);
            lblFrecuencia.TabIndex = 0;
            lblFrecuencia.Text = "Fecha de pago";
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
            cmbSemanal.Size = new Size(800, 29);
            cmbSemanal.TabIndex = 6;
            cmbSemanal.Visible = false;
            cmbSemanal.SelectedIndexChanged += Control_ValueChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Dock = DockStyle.Top;
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(0, 29);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(800, 29);
            dtpFecha.TabIndex = 7;
            dtpFecha.Value = new DateTime(2025, 6, 16, 22, 5, 39, 724);
            dtpFecha.Visible = false;
            dtpFecha.ValueChanged += Control_ValueChanged;
            // 
            // pnlFrecuencia
            // 
            pnlFrecuencia.Controls.Add(dtpFecha);
            pnlFrecuencia.Controls.Add(cmbSemanal);
            pnlFrecuencia.Dock = DockStyle.Top;
            pnlFrecuencia.Font = new Font("Segoe UI", 12F);
            pnlFrecuencia.Location = new Point(0, 175);
            pnlFrecuencia.Name = "pnlFrecuencia";
            pnlFrecuencia.Size = new Size(800, 50);
            pnlFrecuencia.TabIndex = 0;
            // 
            // lblNumCuotas
            // 
            lblNumCuotas.AutoSize = true;
            lblNumCuotas.Dock = DockStyle.Top;
            lblNumCuotas.Font = new Font("Segoe UI", 12F);
            lblNumCuotas.Location = new Point(0, 225);
            lblNumCuotas.Name = "lblNumCuotas";
            lblNumCuotas.Size = new Size(145, 21);
            lblNumCuotas.TabIndex = 6;
            lblNumCuotas.Text = "Cantidad de cuotas:";
            // 
            // lblMontoCuotas
            // 
            lblMontoCuotas.AutoSize = true;
            lblMontoCuotas.Dock = DockStyle.Top;
            lblMontoCuotas.Font = new Font("Segoe UI", 12F);
            lblMontoCuotas.Location = new Point(0, 275);
            lblMontoCuotas.Name = "lblMontoCuotas";
            lblMontoCuotas.Size = new Size(158, 21);
            lblMontoCuotas.TabIndex = 9;
            lblMontoCuotas.Text = "Monto de cada cuota:";
            // 
            // txtMontoCuotas
            // 
            txtMontoCuotas.Dock = DockStyle.Top;
            txtMontoCuotas.Enabled = false;
            txtMontoCuotas.Font = new Font("Segoe UI", 12F);
            txtMontoCuotas.Location = new Point(0, 296);
            txtMontoCuotas.Name = "txtMontoCuotas";
            txtMontoCuotas.Size = new Size(800, 29);
            txtMontoCuotas.TabIndex = 10;
            txtMontoCuotas.TextChanged += Control_ValueChanged;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Dock = DockStyle.Bottom;
            btnCrearCuenta.Font = new Font("Segoe UI", 12F);
            btnCrearCuenta.Location = new Point(0, 439);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.RightToLeft = RightToLeft.Yes;
            btnCrearCuenta.Size = new Size(800, 31);
            btnCrearCuenta.TabIndex = 12;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // txtMontoCuenta
            // 
            txtMontoCuenta.Dock = DockStyle.Top;
            txtMontoCuenta.Font = new Font("Segoe UI", 12F);
            txtMontoCuenta.Location = new Point(0, 71);
            txtMontoCuenta.Name = "txtMontoCuenta";
            txtMontoCuenta.Size = new Size(800, 29);
            txtMontoCuenta.TabIndex = 7;
            txtMontoCuenta.TextChanged += TextBox_TextChanged;
            txtMontoCuenta.KeyPress += txtChanged_KeyPress;
            // 
            // txtCantCuotas
            // 
            txtCantCuotas.Dock = DockStyle.Top;
            txtCantCuotas.Font = new Font("Segoe UI", 12F);
            txtCantCuotas.Location = new Point(0, 246);
            txtCantCuotas.Name = "txtCantCuotas";
            txtCantCuotas.Size = new Size(800, 29);
            txtCantCuotas.TabIndex = 13;
            txtCantCuotas.TextChanged += TextBox_TextChanged;
            txtCantCuotas.KeyPress += txtChanged_KeyPress;
            // 
            // cmbCuenta
            // 
            cmbCuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCuenta.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCuenta.Dock = DockStyle.Top;
            cmbCuenta.Font = new Font("Segoe UI", 12F);
            cmbCuenta.FormattingEnabled = true;
            cmbCuenta.Location = new Point(0, 21);
            cmbCuenta.Name = "cmbCuenta";
            cmbCuenta.Size = new Size(800, 29);
            cmbCuenta.TabIndex = 14;
            // 
            // DgvPagos
            // 
            DgvPagos.AllowUserToAddRows = false;
            DgvPagos.AllowUserToDeleteRows = false;
            DgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagos.Columns.AddRange(new DataGridViewColumn[] { Pagos, Pagado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPagos.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPagos.Dock = DockStyle.Fill;
            DgvPagos.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvPagos.Location = new Point(0, 325);
            DgvPagos.Name = "DgvPagos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPagos.Size = new Size(800, 114);
            DgvPagos.TabIndex = 15;
            DgvPagos.CellContentClick += DgvPagos_CellContentClick;
            // 
            // Pagos
            // 
            Pagos.HeaderText = "Fecha del pago";
            Pagos.Name = "Pagos";
            Pagos.ReadOnly = true;
            // 
            // Pagado
            // 
            Pagado.HeaderText = "Pago hecho";
            Pagado.Name = "Pagado";
            Pagado.Resizable = DataGridViewTriState.True;
            Pagado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FrmAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 470);
            ControlBox = false;
            Controls.Add(DgvPagos);
            Controls.Add(txtMontoCuotas);
            Controls.Add(lblMontoCuotas);
            Controls.Add(txtCantCuotas);
            Controls.Add(btnCrearCuenta);
            Controls.Add(lblNumCuotas);
            Controls.Add(pnlFrecuencia);
            Controls.Add(lblFrecuencia);
            Controls.Add(pnlRadios);
            Controls.Add(lblTipoPago);
            Controls.Add(txtMontoCuenta);
            Controls.Add(lblMonto);
            Controls.Add(cmbCuenta);
            Controls.Add(lblCuenta);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cuenta";
            WindowState = FormWindowState.Maximized;
            Activated += FrmAgregarCuenta_Activated;
            pnlRadios.ResumeLayout(false);
            pnlRadios.PerformLayout();
            pnlFrecuencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Label lblMonto;
        private Label lblTipoPago;
        private Panel pnlRadios;
        private RadioButton RbSemanal;
        private RadioButton RbQuincenal;
        private RadioButton RbMensual;
        private Label lblFrecuencia;
        private ComboBox cmbSemanal;
        private DateTimePicker dtpFecha;
        private Panel pnlFrecuencia;
        private CheckBox cbIniciado;
        private Label lblNumCuotas;
        private Label lblMontoCuotas;
        private TextBox txtMontoCuotas;
        private Button btnCrearCuenta;
        private TextBox txtMontoCuenta;
        private TextBox txtCantCuotas;
        private ComboBox cmbCuenta;
        private DataGridView DgvPagos;
        private DataGridViewTextBoxColumn Pagos;
        private DataGridViewCheckBoxColumn Pagado;
    }
}