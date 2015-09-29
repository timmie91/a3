using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (encryptTextBox.Text.Trim() != "")
            {
                ServiceRef.ServiceClient encrypt = new ServiceRef.ServiceClient();
                String str = Convert.ToString(this.encryptTextBox.Text);
                string result = encrypt.Encrypt(str);
                this.encMsgLabel.Text = result.ToString();
                encrypt.Close();
            }
            else{
                MessageBox.Show("Please enter a txt");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encMsgLabel_Click(object sender, EventArgs e)
        {

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (encMsgLabel.Text.Trim() != "")
            {
                ServiceRef.ServiceClient decrypt = new ServiceRef.ServiceClient();
                string result = decrypt.Decrypt(this.encMsgLabel.Text);
                this.label2.Text = result.ToString();
                decrypt.Close();
            }
            else
            {
                MessageBox.Show("Please enter a txt");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void generateStringBtn_Click(object sender, EventArgs e)
        {
            imageVerifyRef.ServiceClient proxy = new imageVerifyRef.ServiceClient();
            string imageVerify = proxy.GetVerifierString(lengthNumberTextBox.Text);
            Image image = System.Drawing.Image.FromStream(proxy.GetImage(imageVerify));
            this.pictureBox1.Image = image;
        }
    }
}
