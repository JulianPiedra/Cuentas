namespace Cuentas
{
    partial class FrmVerPagos
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCliente = new Label();
            lblMonto = new Label();
            lblMontoPendiente = new Label();
            lblCuotas = new Label();
            lblCanceladas = new Label();
            lblSiguientePago = new Label();
            lblTipoPago = new Label();
            btnEditar = new Button();
            lblTipoCuenta = new Label();
            DgvPagos = new DataGridView();
            IdPago = new DataGridViewTextBoxColumn();
            Pagos = new DataGridViewTextBoxColumn();
            Pagado = new DataGridViewCheckBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPagos).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblCliente);
            flowLayoutPanel1.Controls.Add(lblMonto);
            flowLayoutPanel1.Controls.Add(lblMontoPendiente);
            flowLayoutPanel1.Controls.Add(lblCuotas);
            flowLayoutPanel1.Controls.Add(lblCanceladas);
            flowLayoutPanel1.Controls.Add(lblSiguientePago);
            flowLayoutPanel1.Controls.Add(lblTipoPago);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(lblTipoCuenta);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 910);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F);
            lblCliente.Location = new Point(6, 49);
            lblCliente.Margin = new Padding(6, 49, 6, 49);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 21);
            lblCliente.TabIndex = 9;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 12F);
            lblMonto.Location = new Point(6, 168);
            lblMonto.Margin = new Padding(6, 49, 6, 49);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(0, 21);
            lblMonto.TabIndex = 8;
            // 
            // lblMontoPendiente
            // 
            lblMontoPendiente.AutoSize = true;
            lblMontoPendiente.Location = new Point(6, 287);
            lblMontoPendiente.Margin = new Padding(6, 49, 6, 49);
            lblMontoPendiente.Name = "lblMontoPendiente";
            lblMontoPendiente.Size = new Size(0, 21);
            lblMontoPendiente.TabIndex = 10;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 12F);
            lblCuotas.Location = new Point(6, 406);
            lblCuotas.Margin = new Padding(6, 49, 6, 49);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(0, 21);
            lblCuotas.TabIndex = 7;
            // 
            // lblCanceladas
            // 
            lblCanceladas.AutoSize = true;
            lblCanceladas.Font = new Font("Segoe UI", 12F);
            lblCanceladas.Location = new Point(6, 525);
            lblCanceladas.Margin = new Padding(6, 49, 6, 49);
            lblCanceladas.Name = "lblCanceladas";
            lblCanceladas.Size = new Size(0, 21);
            lblCanceladas.TabIndex = 6;
            // 
            // lblSiguientePago
            // 
            lblSiguientePago.AutoSize = true;
            lblSiguientePago.Location = new Point(6, 644);
            lblSiguientePago.Margin = new Padding(6, 49, 6, 49);
            lblSiguientePago.Name = "lblSiguientePago";
            lblSiguientePago.Size = new Size(0, 21);
            lblSiguientePago.TabIndex = 5;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 12F);
            lblTipoPago.Location = new Point(6, 763);
            lblTipoPago.Margin = new Padding(6, 49, 6, 49);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(0, 21);
            lblTipoPago.TabIndex = 18;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(8, 138, 100);
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(4, 837);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(409, 52);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar cuenta";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Font = new Font("Segoe UI", 12F);
            lblTipoCuenta.Location = new Point(423, 49);
            lblTipoCuenta.Margin = new Padding(6, 49, 6, 49);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(0, 21);
            lblTipoCuenta.TabIndex = 19;
            // 
            // DgvPagos
            // 
            DgvPagos.AllowUserToAddRows = false;
            DgvPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            DgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvPagos.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagos.Columns.AddRange(new DataGridViewColumn[] { IdPago, Pagos, Pagado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvPagos.DefaultCellStyle = dataGridViewCellStyle6;
            DgvPagos.Dock = DockStyle.Fill;
            DgvPagos.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvPagos.Location = new Point(650, 0);
            DgvPagos.Margin = new Padding(4);
            DgvPagos.Name = "DgvPagos";
            DgvPagos.RowHeadersVisible = false;
            DgvPagos.Size = new Size(636, 910);
            DgvPagos.TabIndex = 16;
            DgvPagos.CellContentClick += DgvPagos_CellContentClick;
            // 
            // IdPago
            // 
            IdPago.HeaderText = "IdPago";
            IdPago.Name = "IdPago";
            IdPago.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdPago.Visible = false;
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
            // FrmVerPagos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 910);
            Controls.Add(DgvPagos);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmVerPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVerPagos";
            Load += FrmVerPagos_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCliente;
        private Label lblMonto;
        private Label lblCuotas;
        private Label lblCanceladas;
        private Label lblSiguientePago;
        private DataGridView DgvPagos;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn Pagos;
        private DataGridViewCheckBoxColumn Pagado;
        private Label lblMontoPendiente;
        private Button btnEditar;
        private Label lblTipoPago;
        private Label lblTipoCuenta;
    }
}