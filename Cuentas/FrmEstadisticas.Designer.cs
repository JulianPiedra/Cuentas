namespace Cuentas
{
    partial class FrmEstadisticas
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
            pbMontoTotalPendientes = new PictureBox();
            pbMontoTotalCuentas = new PictureBox();
            pbTotalCuentasActivas = new PictureBox();
            pbTotalCuentas = new PictureBox();
            pbTotalClientes = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMontoTotalCuentasPendientes = new Label();
            lblMontoTotalCuentas = new Label();
            lblTotalCuentasActivas = new Label();
            lblTotalCuentas = new Label();
            lblTotalClientes = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMontoTotalPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMontoTotalCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalCuentasActivas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalClientes).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pbMontoTotalPendientes
            // 
            pbMontoTotalPendientes.Dock = DockStyle.Fill;
            pbMontoTotalPendientes.Image = Properties.Resources.time;
            pbMontoTotalPendientes.Location = new Point(0, 0);
            pbMontoTotalPendientes.Name = "pbMontoTotalPendientes";
            pbMontoTotalPendientes.Size = new Size(154, 163);
            pbMontoTotalPendientes.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMontoTotalPendientes.TabIndex = 4;
            pbMontoTotalPendientes.TabStop = false;
            // 
            // pbMontoTotalCuentas
            // 
            pbMontoTotalCuentas.Dock = DockStyle.Fill;
            pbMontoTotalCuentas.Image = Properties.Resources.profit;
            pbMontoTotalCuentas.Location = new Point(0, 0);
            pbMontoTotalCuentas.Name = "pbMontoTotalCuentas";
            pbMontoTotalCuentas.Size = new Size(154, 163);
            pbMontoTotalCuentas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMontoTotalCuentas.TabIndex = 3;
            pbMontoTotalCuentas.TabStop = false;
            // 
            // pbTotalCuentasActivas
            // 
            pbTotalCuentasActivas.Dock = DockStyle.Fill;
            pbTotalCuentasActivas.Image = Properties.Resources.bank;
            pbTotalCuentasActivas.Location = new Point(0, 0);
            pbTotalCuentasActivas.Name = "pbTotalCuentasActivas";
            pbTotalCuentasActivas.Size = new Size(154, 163);
            pbTotalCuentasActivas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbTotalCuentasActivas.TabIndex = 2;
            pbTotalCuentasActivas.TabStop = false;
            // 
            // pbTotalCuentas
            // 
            pbTotalCuentas.Dock = DockStyle.Fill;
            pbTotalCuentas.Image = Properties.Resources.accounting;
            pbTotalCuentas.Location = new Point(0, 0);
            pbTotalCuentas.Name = "pbTotalCuentas";
            pbTotalCuentas.Size = new Size(154, 163);
            pbTotalCuentas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbTotalCuentas.TabIndex = 1;
            pbTotalCuentas.TabStop = false;
            // 
            // pbTotalClientes
            // 
            pbTotalClientes.Dock = DockStyle.Fill;
            pbTotalClientes.Image = Properties.Resources.customer;
            pbTotalClientes.Location = new Point(0, 0);
            pbTotalClientes.Name = "pbTotalClientes";
            pbTotalClientes.Size = new Size(154, 163);
            pbTotalClientes.SizeMode = PictureBoxSizeMode.CenterImage;
            pbTotalClientes.TabIndex = 0;
            pbTotalClientes.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblMontoTotalCuentasPendientes, 4, 1);
            tableLayoutPanel1.Controls.Add(lblMontoTotalCuentas, 3, 1);
            tableLayoutPanel1.Controls.Add(lblTotalCuentasActivas, 2, 1);
            tableLayoutPanel1.Controls.Add(lblTotalCuentas, 1, 1);
            tableLayoutPanel1.Controls.Add(lblTotalClientes, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 4, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lblMontoTotalCuentasPendientes
            // 
            lblMontoTotalCuentasPendientes.Dock = DockStyle.Fill;
            lblMontoTotalCuentasPendientes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMontoTotalCuentasPendientes.Location = new Point(643, 225);
            lblMontoTotalCuentasPendientes.Name = "lblMontoTotalCuentasPendientes";
            lblMontoTotalCuentasPendientes.Size = new Size(154, 225);
            lblMontoTotalCuentasPendientes.TabIndex = 11;
            lblMontoTotalCuentasPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMontoTotalCuentas
            // 
            lblMontoTotalCuentas.Dock = DockStyle.Fill;
            lblMontoTotalCuentas.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMontoTotalCuentas.Location = new Point(483, 225);
            lblMontoTotalCuentas.Name = "lblMontoTotalCuentas";
            lblMontoTotalCuentas.Size = new Size(154, 225);
            lblMontoTotalCuentas.TabIndex = 10;
            lblMontoTotalCuentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCuentasActivas
            // 
            lblTotalCuentasActivas.Dock = DockStyle.Fill;
            lblTotalCuentasActivas.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTotalCuentasActivas.Location = new Point(323, 225);
            lblTotalCuentasActivas.Name = "lblTotalCuentasActivas";
            lblTotalCuentasActivas.Size = new Size(154, 225);
            lblTotalCuentasActivas.TabIndex = 9;
            lblTotalCuentasActivas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCuentas
            // 
            lblTotalCuentas.Dock = DockStyle.Fill;
            lblTotalCuentas.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTotalCuentas.Location = new Point(163, 225);
            lblTotalCuentas.Name = "lblTotalCuentas";
            lblTotalCuentas.Size = new Size(154, 225);
            lblTotalCuentas.TabIndex = 8;
            lblTotalCuentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.Dock = DockStyle.Fill;
            lblTotalClientes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTotalClientes.Location = new Point(3, 225);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(154, 225);
            lblTotalClientes.TabIndex = 7;
            lblTotalClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbTotalClientes);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 219);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label1.Location = new Point(0, 163);
            label1.Name = "label1";
            label1.Size = new Size(154, 56);
            label1.TabIndex = 5;
            label1.Text = "Clientes totales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(pbMontoTotalPendientes);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold);
            panel5.Location = new Point(643, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 219);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label5.Location = new Point(0, 163);
            label5.Name = "label5";
            label5.Size = new Size(154, 56);
            label5.TabIndex = 9;
            label5.Text = "Monto total de cuentas activas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbMontoTotalCuentas);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(483, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 219);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label4.Location = new Point(0, 163);
            label4.Name = "label4";
            label4.Size = new Size(154, 56);
            label4.TabIndex = 8;
            label4.Text = "Monto total de cuentas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbTotalCuentasActivas);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(323, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 219);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label3.Location = new Point(0, 163);
            label3.Name = "label3";
            label3.Size = new Size(154, 56);
            label3.TabIndex = 7;
            label3.Text = "Total de cuentas activas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbTotalCuentas);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(163, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 219);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label2.Location = new Point(0, 163);
            label2.Name = "label2";
            label2.Size = new Size(154, 56);
            label2.TabIndex = 6;
            label2.Text = "Cuentas totales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadísticas";
            WindowState = FormWindowState.Maximized;
            Activated += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)pbMontoTotalPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMontoTotalCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalCuentasActivas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTotalClientes).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbMontoTotalPendientes;
        private PictureBox pbMontoTotalCuentas;
        private PictureBox pbTotalCuentasActivas;
        private PictureBox pbTotalCuentas;
        private PictureBox pbTotalClientes;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label lblMontoTotalCuentasPendientes;
        private Label lblMontoTotalCuentas;
        private Label lblTotalCuentasActivas;
        private Label lblTotalCuentas;
        private Label lblTotalClientes;
    }
}