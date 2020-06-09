using MovieTicketBooking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.DataAccess
{
    public class UserDA
    {
        public string path = @"Data Source=MMANMADHAN01\SQLEXPRESS;Initial Catalog=MovieTicketBooking;Integrated Security=SSPI";

        public int Login(string Mobile, string Password)
        {
            int status;
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_LoginCheck", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Password",Password);
                status = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            return status;
        }

        public UserInfo SignUp(UserInfo user)
        {
            UserInfo User = new UserInfo();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_SignUp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                cmd.Parameters.AddWithValue("@mobile", user.Mobile);
                cmd.Parameters.AddWithValue("@password", user.Password);
                int RowCount = cmd.ExecuteNonQuery();
                con.Close();
                User.Name = user.Name;
                User.Password = user.Password;
            }
            return User;
        }
        public UserInfo Search(UserInfo user)
        {
            UserInfo User = new UserInfo();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    User.UserID = Convert.ToInt32(dr["UserID"]);
                    User.Name = Convert.ToString(dr["Name"]);
                }
            }
            return User;
        }

        public string IsNewUser(string Mobile)
        {
            string user ;
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_IsNewUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                user = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            return user;
        }
    }
}
