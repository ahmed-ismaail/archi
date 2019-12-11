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
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();

           ServiceReference1.UserClass user = new ServiceReference1.UserClass();


            user = s.ViewProfile(LoginForm.staticEmail);

            name_Holder.Text = user.name;
            email_Holder.Text = user.email;
            age_Holder.Text = (user.age).ToString();
            gender_holder.Text = user.gender;
            weight_Holder.Text = (user.weight).ToString();
            password_Holder.Text = user.password;

        }
    }
}
