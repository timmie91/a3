using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            question2.Service1Client myWcfProxy = new question2.Service1Client();
            int dF = Convert.ToInt16(this.getCTextBox.Text);
            int result = myWcfProxy.f2c(dF);
            this.label1.Text = result.ToString()+" degree C";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c2fButton_Click(object sender, EventArgs e)
        {
            question2.Service1Client myWcfProxy = new question2.Service1Client();
            int dC = Convert.ToInt16(this.getFTextBox.Text);
            int result = myWcfProxy.c2f(dC);
            this.label2.Text = result.ToString()+" degree F";
        }
    }
}
