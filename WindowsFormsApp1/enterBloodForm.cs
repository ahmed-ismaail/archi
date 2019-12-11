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
    public partial class enterBloodForm : Form
    {
        public enterBloodForm()
        {
            InitializeComponent();
        }

        public static int staticBloodPressure=0;

        private void enterBloodForm_Load(object sender, EventArgs e)
        {
        }

        private void saveBloodPressure_btn_Click(object sender, EventArgs e)
        {
            staticBloodPressure = int.Parse(blood_txtbox.Text);

            enterBloodForm BF = new enterBloodForm();
            BF.Hide();
        }
    }
}
