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
            menuStrip1 = new MenuStrip();
            verCuentasToolStripMenuItem = new ToolStripMenuItem();
            crearCuentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verCuentasToolStripMenuItem, crearCuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menu_bar";
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menu_bar";
            // 
            // verCuentasToolStripMenuItem
            // 
            verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            verCuentasToolStripMenuItem.Size = new Size(113, 19);
            verCuentasToolStripMenuItem.Text = "Ver cuentas";
            verCuentasToolStripMenuItem.Click += verCuentasToolStripMenuItem_Click;
            // 
            // crearCuentaToolStripMenuItem
            // 
            crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            crearCuentaToolStripMenuItem.Size = new Size(113, 19);
            crearCuentaToolStripMenuItem.Text = "Crear cuenta";
            crearCuentaToolStripMenuItem.Click += crearCuentaToolStripMenuItem_Click;
            // 
            // FrmAdministradorDeCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmAdministradorDeCuentas";
            Text = "Cuentas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearCuentaToolStripMenuItem;
        private ToolStripMenuItem verCuentasToolStripMenuItem;
    }
}
