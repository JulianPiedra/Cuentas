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
            panel1 = new Panel();
            lblTotalClientes = new Label();
            panel5 = new Panel();
            lblMontoTotalCuentasPendientes = new Label();
            panel4 = new Panel();
            lblMontoTotalCuentas = new Label();
            panel3 = new Panel();
            lblTotalCuentasActivas = new Label();
            panel2 = new Panel();
            lblTotalCuentas = new Label();
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
            pbMontoTotalPendientes.Dock = DockStyle.Top;
            pbMontoTotalPendientes.Image = Properties.Resources.time;
            pbMontoTotalPendientes.Location = new Point(0, 0);
            pbMontoTotalPendientes.Name = "pbMontoTotalPendientes";
            pbMontoTotalPendientes.Size = new Size(154, 172);
            pbMontoTotalPendientes.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMontoTotalPendientes.TabIndex = 4;
            pbMontoTotalPendientes.TabStop = false;
            // 
            // pbMontoTotalCuentas
            // 
            pbMontoTotalCuentas.Dock = DockStyle.Top;
            pbMontoTotalCuentas.Image = Properties.Resources.profit;
            pbMontoTotalCuentas.Location = new Point(0, 0);
            pbMontoTotalCuentas.Name = "pbMontoTotalCuentas";
            pbMontoTotalCuentas.Size = new Size(154, 172);
            pbMontoTotalCuentas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMontoTotalCuentas.TabIndex = 3;
            pbMontoTotalCuentas.TabStop = false;
            // 
            // pbTotalCuentasActivas
            // 
            pbTotalCuentasActivas.Dock = DockStyle.Top;
            pbTotalCuentasActivas.Image = Properties.Resources.bank;
            pbTotalCuentasActivas.Location = new Point(0, 0);
            pbTotalCuentasActivas.Name = "pbTotalCuentasActivas";
            pbTotalCuentasActivas.Size = new Size(154, 172);
            pbTotalCuentasActivas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbTotalCuentasActivas.TabIndex = 2;
            pbTotalCuentasActivas.TabStop = false;
            // 
            // pbTotalCuentas
            // 
            pbTotalCuentas.Dock = DockStyle.Top;
            pbTotalCuentas.Image = Properties.Resources.accounting;
            pbTotalCuentas.Location = new Point(0, 0);
            pbTotalCuentas.Name = "pbTotalCuentas";
            pbTotalCuentas.Size = new Size(154, 172);
            pbTotalCuentas.SizeMode = PictureBoxSizeMode.CenterImage;
            pbTotalCuentas.TabIndex = 1;
            pbTotalCuentas.TabStop = false;
            // 
            // pbTotalClientes
            // 
            pbTotalClientes.Dock = DockStyle.Top;
            pbTotalClientes.Image = Properties.Resources.customer;
            pbTotalClientes.Location = new Point(0, 0);
            pbTotalClientes.Name = "pbTotalClientes";
            pbTotalClientes.Size = new Size(154, 172);
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
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 4, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbTotalClientes);
            panel1.Controls.Add(lblTotalClientes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 444);
            panel1.TabIndex = 6;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.Dock = DockStyle.Bottom;
            lblTotalClientes.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalClientes.Location = new Point(0, 175);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(154, 269);
            lblTotalClientes.TabIndex = 5;
            lblTotalClientes.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(pbMontoTotalPendientes);
            panel5.Controls.Add(lblMontoTotalCuentasPendientes);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold);
            panel5.Location = new Point(643, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 444);
            panel5.TabIndex = 2;
            // 
            // lblMontoTotalCuentasPendientes
            // 
            lblMontoTotalCuentasPendientes.Dock = DockStyle.Bottom;
            lblMontoTotalCuentasPendientes.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblMontoTotalCuentasPendientes.Location = new Point(0, 175);
            lblMontoTotalCuentasPendientes.Name = "lblMontoTotalCuentasPendientes";
            lblMontoTotalCuentasPendientes.Size = new Size(154, 269);
            lblMontoTotalCuentasPendientes.TabIndex = 9;
            lblMontoTotalCuentasPendientes.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbMontoTotalCuentas);
            panel4.Controls.Add(lblMontoTotalCuentas);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(483, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 444);
            panel4.TabIndex = 2;
            // 
            // lblMontoTotalCuentas
            // 
            lblMontoTotalCuentas.Dock = DockStyle.Bottom;
            lblMontoTotalCuentas.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblMontoTotalCuentas.Location = new Point(0, 175);
            lblMontoTotalCuentas.Name = "lblMontoTotalCuentas";
            lblMontoTotalCuentas.Size = new Size(154, 269);
            lblMontoTotalCuentas.TabIndex = 8;
            lblMontoTotalCuentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbTotalCuentasActivas);
            panel3.Controls.Add(lblTotalCuentasActivas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(323, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 444);
            panel3.TabIndex = 2;
            // 
            // lblTotalCuentasActivas
            // 
            lblTotalCuentasActivas.Dock = DockStyle.Bottom;
            lblTotalCuentasActivas.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalCuentasActivas.Location = new Point(0, 175);
            lblTotalCuentasActivas.Name = "lblTotalCuentasActivas";
            lblTotalCuentasActivas.Size = new Size(154, 269);
            lblTotalCuentasActivas.TabIndex = 7;
            lblTotalCuentasActivas.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbTotalCuentas);
            panel2.Controls.Add(lblTotalCuentas);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(163, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 444);
            panel2.TabIndex = 1;
            // 
            // lblTotalCuentas
            // 
            lblTotalCuentas.Dock = DockStyle.Bottom;
            lblTotalCuentas.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalCuentas.Location = new Point(0, 175);
            lblTotalCuentas.Name = "lblTotalCuentas";
            lblTotalCuentas.Size = new Size(154, 269);
            lblTotalCuentas.TabIndex = 6;
            lblTotalCuentas.TextAlign = ContentAlignment.TopCenter;
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
            Load += FrmEstadisticas_Load;
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
        private Label lblTotalClientes;
        private Panel panel1;
        private Panel panel5;
        private Label lblMontoTotalCuentasPendientes;
        private Panel panel4;
        private Label lblMontoTotalCuentas;
        private Panel panel3;
        private Label lblTotalCuentasActivas;
        private Panel panel2;
        private Label lblTotalCuentas;
    }
}