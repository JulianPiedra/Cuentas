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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCliente = new Label();
            lblMonto = new Label();
            lblCuotas = new Label();
            lblCanceladas = new Label();
            lblSiguientePago = new Label();
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
            flowLayoutPanel1.Controls.Add(lblCliente);
            flowLayoutPanel1.Controls.Add(lblMonto);
            flowLayoutPanel1.Controls.Add(lblCuotas);
            flowLayoutPanel1.Controls.Add(lblCanceladas);
            flowLayoutPanel1.Controls.Add(lblSiguientePago);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(321, 650);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F);
            lblCliente.Location = new Point(5, 35);
            lblCliente.Margin = new Padding(5, 35, 5, 35);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 21);
            lblCliente.TabIndex = 9;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 12F);
            lblMonto.Location = new Point(5, 126);
            lblMonto.Margin = new Padding(5, 35, 5, 35);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(0, 21);
            lblMonto.TabIndex = 8;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 12F);
            lblCuotas.Location = new Point(5, 217);
            lblCuotas.Margin = new Padding(5, 35, 5, 35);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(0, 21);
            lblCuotas.TabIndex = 7;
            // 
            // lblCanceladas
            // 
            lblCanceladas.AutoSize = true;
            lblCanceladas.Font = new Font("Segoe UI", 12F);
            lblCanceladas.Location = new Point(5, 308);
            lblCanceladas.Margin = new Padding(5, 35, 5, 35);
            lblCanceladas.Name = "lblCanceladas";
            lblCanceladas.Size = new Size(0, 21);
            lblCanceladas.TabIndex = 6;
            // 
            // lblSiguientePago
            // 
            lblSiguientePago.AutoSize = true;
            lblSiguientePago.Location = new Point(5, 399);
            lblSiguientePago.Margin = new Padding(5, 35, 5, 35);
            lblSiguientePago.Name = "lblSiguientePago";
            lblSiguientePago.Size = new Size(0, 21);
            lblSiguientePago.TabIndex = 5;
            // 
            // DgvPagos
            // 
            DgvPagos.AllowUserToAddRows = false;
            DgvPagos.AllowUserToDeleteRows = false;
            DgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagos.Columns.AddRange(new DataGridViewColumn[] { IdPago, Pagos, Pagado });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvPagos.DefaultCellStyle = dataGridViewCellStyle1;
            DgvPagos.Dock = DockStyle.Fill;
            DgvPagos.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvPagos.Location = new Point(321, 0);
            DgvPagos.Name = "DgvPagos";
            DgvPagos.Size = new Size(679, 650);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(DgvPagos);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmVerPagos";
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
    }
}