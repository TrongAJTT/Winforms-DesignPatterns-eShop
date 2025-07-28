using System;
using System.Windows.Forms;

namespace _3S_eShop
{
    public partial class TestEncrypt : Form
    {
        public TestEncrypt()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            txtDown.Texts = Cipher3S.AESIV.Encrypt(txtUp.Texts);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            txtDown.Texts = Cipher3S.AESIV.Decrypt(txtUp.Texts);
        }
    }
}
