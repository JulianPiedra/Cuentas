namespace Cuentas
{
    partial class FrmOtp
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
            lblOTP = new Label();
            txtOTP = new TextBox();
            btnVerify = new Button();
            SuspendLayout();
            // 
            // lblOTP
            // 
            lblOTP.Location = new Point(260, 133);
            lblOTP.Name = "lblOTP";
            lblOTP.Size = new Size(300, 21);
            lblOTP.TabIndex = 0;
            lblOTP.Text = "Ingrese la contraseña dinámica";
            lblOTP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOTP
            // 
            txtOTP.BackColor = SystemColors.Control;
            txtOTP.Location = new Point(260, 157);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(300, 29);
            txtOTP.TabIndex = 1;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.FromArgb(8, 138, 100);
            btnVerify.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(295, 236);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(230, 80);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verificar contraseña";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // FrmOtp
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 401);
            Controls.Add(btnVerify);
            Controls.Add(txtOTP);
            Controls.Add(lblOTP);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximumSize = new Size(820, 440);
            MinimumSize = new Size(820, 440);
            Name = "FrmOtp";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOTP;
        private TextBox txtOTP;
        private Button btnVerify;
    }
}