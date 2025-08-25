namespace Cuentas
{
    partial class FrmVerClientes
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
            DgvClientes = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            VerCliente = new DataGridViewButtonColumn();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvClientes
            // 
            DgvClientes.AllowUserToAddRows = false;
            DgvClientes.AllowUserToDeleteRows = false;
            DgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            DgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvClientes.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Columns.AddRange(new DataGridViewColumn[] { IdCliente, Nombre, Telefono, Correo, VerCliente });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            DgvClientes.Dock = DockStyle.Fill;
            DgvClientes.EditMode = DataGridViewEditMode.EditOnEnter;
            DgvClientes.Location = new Point(0, 52);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvClientes.RowHeadersVisible = false;
            DgvClientes.Size = new Size(800, 398);
            DgvClientes.TabIndex = 0;
            DgvClientes.CellContentClick += DgvClientes_CellContentClick;
            DgvClientes.CellFormatting += DgvClientess_CellFormatting;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "Cedula";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // VerCliente
            // 
            VerCliente.HeaderText = "Detalles Clientes";
            VerCliente.Name = "VerCliente";
            VerCliente.ReadOnly = true;
            VerCliente.Text = "Ver detalles del cliente";
            VerCliente.UseColumnTextForButtonValue = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Control;
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(0, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(800, 29);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Dock = DockStyle.Top;
            lblBuscar.Font = new Font("Segoe UI", 12F);
            lblBuscar.Location = new Point(0, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(112, 21);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 4;
            // 
            // FrmVerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(DgvClientes);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmVerClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmVerClientes_Load;
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvClientes;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel panel1;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewButtonColumn VerCliente;
    }
}