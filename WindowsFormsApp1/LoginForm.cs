using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ser = new ServiceReference1.WebService1SoapClient();

            if (ser.LoginFunc(email_txtbox.Text, password_txtbox.Text))
            {
                Form1 f = new Form1();

                //LoginForm loginform = new LoginForm();
                //loginform.Close();

                f.Show();
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();

            f.Show();
        }
    }
}
