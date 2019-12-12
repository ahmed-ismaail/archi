using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication111115111
{
    public class WCFService : IWCFService
    {
        //two way pattern (not sure)
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
                 user.userId = int.Parse(dr[0].ToString());
                 user.email = dr[1].ToString();
                 user.name = dr[2].ToString();
                 user.age = int.Parse(dr[3].ToString());
                 user.weight = int.Parse(dr[4].ToString());
                 user.gender = dr[5].ToString();
                 user.password = dr[6].ToString();
             }
             dr.Close();
             con.Close();
             return user;   
        }

        //one way (not sure)
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
    }
}
