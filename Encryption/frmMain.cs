using System;
using System.Windows.Forms;

namespace Encryption
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncrpyteText.Text))
            {
                MessageBox.Show("Şifrelenmiş Değer Boş Olamaz");
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtDecryptText.Text = txtEncrpyteText.Text.DecryptText(txtPassword.Text);
                    return;
                }
                txtDecryptText.Text = txtEncrpyteText.Text.DecryptText();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnEncrypte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptText.Text))
            {
                MessageBox.Show("Şifrelenecek Değer Boş Olamaz");
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtEncrpyteText.Text = txtDecryptText.Text.EncryptText(txtPassword.Text);
                    return;
                }
                txtEncrpyteText.Text = txtDecryptText.Text.EncryptText();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
