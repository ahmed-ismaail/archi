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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //public static string str = "";

        private void ViewProfile_btn_Click(object sender, EventArgs e)
        {
           // str = LoginForm.staticEmail;
           // MessageBox.Show(str);
            MainForm m = new MainForm();
            m.Close();

            profileForm p = new profileForm();
            p.Show();
        }

        private void updateProfile_btn_Click(object sender, EventArgs e)
        {
            updateProfileForm u = new updateProfileForm();
            u.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enterBloodForm BF = new enterBloodForm();
            BF.Show();
        }

        private void viewDietPlan_btn_Click(object sender, EventArgs e)
        {
            DietPlanForm DPF = new DietPlanForm();
            DPF.Show();
        }
    }
}
