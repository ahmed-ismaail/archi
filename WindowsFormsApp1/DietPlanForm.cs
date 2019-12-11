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
    public partial class DietPlanForm : Form
    {
        public DietPlanForm()
        {
            InitializeComponent();
        }

        private void DietPlanForm_Load(object sender, EventArgs e)
        {
            if(enterBloodForm.staticBloodPressure>30 && enterBloodForm.staticBloodPressure<50)
            {
                ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();

                ServiceReference1.DietPlanClass plan = new ServiceReference1.DietPlanClass();

                plan = s.ViewDietPlan("typeA");

                veges_Holder.Text = plan.veges;
                fruit_Holder.Text = plan.fruit;
                meat_Holder.Text = plan.meat;
                drinks_Holder.Text = plan.drinks;
                meat_Holder.Text = plan.milk;
            }
        }
    }
}
