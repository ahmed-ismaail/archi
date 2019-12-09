using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication111115111
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class WebService1 : System.Web.Services.WebService
    {
            [WebMethod]
            public bool LoginFunc(string email, string password)
            {

                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ahmed Ismail\\source\\repos\\WebApplication111115111\\WebApplication111115111\\App_Data\\Db.mdf\";Integrated Security=True");
                SqlCommand CmdSql = new SqlCommand("select password from [User] where email=@email", con);
                con.Open();
                CmdSql.CommandType = System.Data.CommandType.Text;
                CmdSql.Parameters.AddWithValue("@email", email);
                SqlDataReader dr = CmdSql.ExecuteReader();
//                setEmail(email);
                string enteredPassword = password;
                string s = "";
                if (dr.Read())
                {
                    s = dr[0].ToString();
                    if (enteredPassword == s)
                    {
                        return true;
                    }
                }
                dr.Close();
                con.Close();

                return false;
            }

            [WebMethod]
            public void Register(string name, int age, int weight, string gender
                                , string email, string password)
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ahmed Ismail\\source\\repos\\WebApplication111115111\\WebApplication111115111\\App_Data\\Db.mdf\";Integrated Security=True");
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [User] (email,name,age,weight,gender,password) VALUES (@email, @name, @age, @weight, @gender, @password)", con);
                con.Open();
                CmdSql.Parameters.AddWithValue("@email", email);
                CmdSql.Parameters.AddWithValue("@name", name);
                CmdSql.Parameters.AddWithValue("@age", age);
                CmdSql.Parameters.AddWithValue("@weight", weight);
                CmdSql.Parameters.AddWithValue("@gender", gender);
                CmdSql.Parameters.AddWithValue("@password", password);
                CmdSql.ExecuteNonQuery();
                con.Close();
            }

            [WebMethod]
            public UserClass ViewProfile(string email)
            {

                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ahmed Ismail\\source\\repos\\WebApplication111115111\\WebApplication111115111\\App_Data\\Db.mdf\";Integrated Security=True");
                SqlCommand CmdSql = new SqlCommand("select * from [User] where email=@email", con);
                con.Open();
                CmdSql.CommandType = System.Data.CommandType.Text;
                CmdSql.Parameters.AddWithValue("@email", email);
                SqlDataReader dr = CmdSql.ExecuteReader();

                UserClass user = new UserClass();

                if (dr.Read())
                {

                    user.email = dr[0].ToString();
                    user.name = dr[1].ToString();
                    user.age = int.Parse(dr[2].ToString());
                    user.weight = int.Parse(dr[3].ToString());
                    user.gender = dr[4].ToString();
                    user.password = dr[5].ToString();
                }
                dr.Close();
                con.Close();
                return user;
            }
        }
    }

