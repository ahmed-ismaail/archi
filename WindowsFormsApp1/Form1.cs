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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            WcfService.WCFServiceClient w = new WcfService.WCFServiceClient();

            WcfService.UserClass user = new WcfService.UserClass();

            w.Register(name_txtbox.Text,int.Parse(age_txtbox.Text),int.Parse(weight_txtbox.Text),
                       gender_txtbox.Text,email_txtbox.Text,password_txtbox.Text);
        }
    }
}
