using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class updateProfileForm : Form
    {
        public updateProfileForm()
        {
            InitializeComponent();
        }
        public static int ID = 0;

        private void updateProfileForm_Load(object sender, EventArgs e)
        {
            WcfService.WCFServiceClient s = new WcfService.WCFServiceClient();

            WcfService.UserClass user = new WcfService.UserClass();

            user = s.ViewProfile(LoginForm.staticEmail);

            ID = user.userId;
            name_txtbox.Text = user.name;
            email_txtBox.Text = user.email;
            age_txtBox.Text = (user.age).ToString();
            gender_txtBox.Text = user.gender;
            weight_txtBox.Text = (user.weight).ToString();
            password_txtBox.Text = user.password;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ahmed Ismail\\source\\repos\\WebApplication111115111\\WebApplication111115111\\App_Data\\Db.mdf\";Integrated Security=True");
            SqlCommand CmdSql = new SqlCommand($"UPDATE [User] set email=@email, name=@name, age=@age, weight=@weight," +
                                               $"gender=@gender, password=@password where Id=@id", con);
            con.Open();
            CmdSql.Parameters.AddWithValue("@id", ID);
            CmdSql.Parameters.AddWithValue("@email", email_txtBox.Text);
            CmdSql.Parameters.AddWithValue("@name", name_txtbox.Text);
            CmdSql.Parameters.AddWithValue("@age", Convert.ToInt32(age_txtBox.Text));
            CmdSql.Parameters.AddWithValue("@weight",Convert.ToInt32(weight_txtBox.Text));
            CmdSql.Parameters.AddWithValue("@gender", gender_txtBox.Text);
            CmdSql.Parameters.AddWithValue("@password", password_txtBox.Text);
            CmdSql.ExecuteNonQuery();
            con.Close();
        }
    }
}
