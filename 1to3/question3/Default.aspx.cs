using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace question3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            int f = proxy.f2c(Convert.ToInt32(TextBox1.Text));
            Label2.Text = "Result: " + f + " degree C";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            int c = proxy.c2f(Convert.ToInt32(TextBox2.Text));
            Label4.Text = "Result: " + c + " degree F";
        }
    }
}