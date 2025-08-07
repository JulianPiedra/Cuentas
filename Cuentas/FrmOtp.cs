using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmOtp : Form
    {
        public FrmOtp()
        {
            InitializeComponent();
        }
        private static readonly string secretKey = ConfigurationManager.AppSettings["OtpPassword"];


        private void btnVerify_Click(object sender, EventArgs e)
        {
            string codeEntered = txtOTP.Text.Trim();
            if (ValidateOtp(codeEntered))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("❌ Código incorrecto, vuelva a intentarlo.");
            }
        }

        private bool ValidateOtp(string code)
        {
            byte[] bytes = Base32Encoding.ToBytes(secretKey);
            Totp totp = new Totp(bytes);

            return totp.VerifyTotp(code, out long timeStepMatched, new VerificationWindow(1, 1));
        }
    }
}
