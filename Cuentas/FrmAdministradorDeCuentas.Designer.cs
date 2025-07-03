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
            verCuentasToolStripMenuItem = new ToolStripMenuItem();
            crearCuentaToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            estadísticasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 12F);
            menuStrip.Items.AddRange(new ToolStripItem[] { verCuentasToolStripMenuItem, crearCuentaToolStripMenuItem, agregarClienteToolStripMenuItem, estadísticasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(995, 29);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menu_bar";
            // 
            // verCuentasToolStripMenuItem
            // 
            verCuentasToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            verCuentasToolStripMenuItem.Size = new Size(102, 25);
            verCuentasToolStripMenuItem.Text = "Ver cuentas";
            verCuentasToolStripMenuItem.Click += verCuentasToolStripMenuItem_Click;
            // 
            // crearCuentaToolStripMenuItem
            // 
            crearCuentaToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            crearCuentaToolStripMenuItem.Size = new Size(110, 25);
            crearCuentaToolStripMenuItem.Text = "Crear cuenta";
            crearCuentaToolStripMenuItem.Click += crearCuentaToolStripMenuItem_Click;
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(127, 25);
            agregarClienteToolStripMenuItem.Text = "Agregar cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // estadísticasToolStripMenuItem
            // 
            estadísticasToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            estadísticasToolStripMenuItem.Size = new Size(101, 25);
            estadísticasToolStripMenuItem.Text = "Estadísticas";
            estadísticasToolStripMenuItem.Click += estadísticasToolStripMenuItem_Click;
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
        private ToolStripMenuItem crearCuentaToolStripMenuItem;
        private ToolStripMenuItem verCuentasToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem estadísticasToolStripMenuItem;
    }
}
