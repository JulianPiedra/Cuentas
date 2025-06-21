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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCliente = new Label();
            lblMonto = new Label();
            lblCuotas = new Label();
            lblCanceladas = new Label();
            lblSiguientePago = new Label();
            tlpCuotas = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
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
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 450);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(5, 35);
            lblCliente.Margin = new Padding(5, 35, 5, 35);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 15);
            lblCliente.TabIndex = 9;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(5, 120);
            lblMonto.Margin = new Padding(5, 35, 5, 35);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(0, 15);
            lblMonto.TabIndex = 8;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(5, 205);
            lblCuotas.Margin = new Padding(5, 35, 5, 35);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(0, 15);
            lblCuotas.TabIndex = 7;
            // 
            // lblCanceladas
            // 
            lblCanceladas.AutoSize = true;
            lblCanceladas.Location = new Point(5, 290);
            lblCanceladas.Margin = new Padding(5, 35, 5, 35);
            lblCanceladas.Name = "lblCanceladas";
            lblCanceladas.Size = new Size(0, 15);
            lblCanceladas.TabIndex = 6;
            // 
            // lblSiguientePago
            // 
            lblSiguientePago.AutoSize = true;
            lblSiguientePago.Location = new Point(5, 375);
            lblSiguientePago.Margin = new Padding(5, 35, 5, 35);
            lblSiguientePago.Name = "lblSiguientePago";
            lblSiguientePago.Size = new Size(0, 15);
            lblSiguientePago.TabIndex = 5;
            // 
            // tlpCuotas
            // 
            tlpCuotas.AutoScroll = true;
            tlpCuotas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpCuotas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCuotas.Dock = DockStyle.Fill;
            tlpCuotas.Font = new Font("Segoe UI", 12F);
            tlpCuotas.Location = new Point(212, 0);
            tlpCuotas.Name = "tlpCuotas";
            tlpCuotas.Size = new Size(588, 450);
            tlpCuotas.TabIndex = 7;
            // 
            // FrmVerPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpCuotas);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmVerPagos";
            Text = "FrmVerPagos";
            Load += FrmVerPagos_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCliente;
        private Label lblMonto;
        private Label lblCuotas;
        private Label lblCanceladas;
        private Label lblSiguientePago;
        private TableLayoutPanel tlpCuotas;
    }
}