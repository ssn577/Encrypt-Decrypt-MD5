using System;
using System.Windows.Forms;

namespace Encrypt_Text
{
    public partial class frmEncrypt : Form
    {
        public frmEncrypt()
        {
            InitializeComponent();
            MD5box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TextResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox.Text)) return;
            MD5Result.Text = md5_converter.Encrypt(Textbox.Text);
            Clipboard.SetText(MD5Result.Text);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MD5box.Text)) return;
                TextResult.Text = md5_converter.Decrypt(MD5box.Text);
                Clipboard.SetText(TextResult.Text);
            }
            catch
            {
                
            }
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Encrypt_Click(sender,e);
            }
        }

        private void MD5box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Decrypt_Click(sender, e);
            }
        }
    }
}
