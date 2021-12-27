using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decryptEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Encrypt_After.Text = StringEncrypt.aesEncryptBase64(tb_Encrypt_Before.Text, tb_Encrypt_Key.Text);
                tb_Decrypt_Before.Text = tb_Encrypt_After.Text;
                tb_Decrypt_Key.Text = tb_Encrypt_Key.Text;
                tb_Decrypt_After.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Decrypt_After.Text = StringEncrypt.aesDecryptBase64(tb_Decrypt_Before.Text, tb_Decrypt_Key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
