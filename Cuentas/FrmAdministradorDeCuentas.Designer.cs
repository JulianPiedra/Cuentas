namespace Cuentas
{
    partial class FrmAdministradorDeCuentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            FrmVerCuentas = new ToolStripMenuItem();
            FrmVerClientes = new ToolStripMenuItem();
            FrmAgregarCuenta = new ToolStripMenuItem();
            FrmAgregarCliente = new ToolStripMenuItem();
            FrmEstadisticas = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 12F);
            menuStrip.Items.AddRange(new ToolStripItem[] { FrmVerCuentas, FrmVerClientes, FrmAgregarCuenta, FrmAgregarCliente, FrmEstadisticas });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(995, 29);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menu_bar";
            // 
            // FrmVerCuentas
            // 
            FrmVerCuentas.Font = new Font("Segoe UI", 12F);
            FrmVerCuentas.Name = "FrmVerCuentas";
            FrmVerCuentas.Size = new Size(102, 25);
            FrmVerCuentas.Text = "Ver cuentas";
            FrmVerCuentas.Click += verCuentasToolStripMenuItem_Click;
            // 
            // FrmVerClientes
            // 
            FrmVerClientes.Name = "FrmVerClientes";
            FrmVerClientes.Size = new Size(101, 25);
            FrmVerClientes.Text = "Ver clientes";
            FrmVerClientes.Click += verClientesToolStripMenuItem_Click;
            // 
            // FrmAgregarCuenta
            // 
            FrmAgregarCuenta.Font = new Font("Segoe UI", 12F);
            FrmAgregarCuenta.Name = "FrmAgregarCuenta";
            FrmAgregarCuenta.Size = new Size(110, 25);
            FrmAgregarCuenta.Text = "Crear cuenta";
            FrmAgregarCuenta.Click += crearCuentaToolStripMenuItem_Click;
            // 
            // FrmAgregarCliente
            // 
            FrmAgregarCliente.Font = new Font("Segoe UI", 12F);
            FrmAgregarCliente.Name = "FrmAgregarCliente";
            FrmAgregarCliente.Size = new Size(127, 25);
            FrmAgregarCliente.Text = "Agregar cliente";
            FrmAgregarCliente.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // FrmEstadisticas
            // 
            FrmEstadisticas.Font = new Font("Segoe UI", 12F);
            FrmEstadisticas.Name = "FrmEstadisticas";
            FrmEstadisticas.Size = new Size(101, 25);
            FrmEstadisticas.Text = "Estadísticas";
            FrmEstadisticas.Click += estadísticasToolStripMenuItem_Click;
            // 
            // FrmAdministradorDeCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(995, 519);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmAdministradorDeCuentas";
            Text = "Cuentas";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem FrmAgregarCuenta;
        private ToolStripMenuItem FrmVerCuentas;
        private ToolStripMenuItem FrmAgregarCliente;
        private ToolStripMenuItem FrmEstadisticas;
        private ToolStripMenuItem FrmVerClientes;
    }
}
