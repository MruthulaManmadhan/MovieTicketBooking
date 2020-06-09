using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBooking.Models;

namespace MovieTicketBooking.DataAccess
{
    public class AdminDA
    {
        public string path = @"Data Source=MMANMADHAN01\SQLEXPRESS;Initial Catalog=MovieTicketBooking;Integrated Security=SSPI";
        internal void AddShow(MovieInfo movie)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_AddShow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@moviename", movie.MovieName);
                cmd.Parameters.AddWithValue("@director", movie.Director);
                cmd.Parameters.AddWithValue("@actor", movie.Actor);
                cmd.Parameters.AddWithValue("@release", movie.Release);
                cmd.Parameters.AddWithValue("@language", movie.Language);
                cmd.Parameters.AddWithValue("@time", movie.Time);
                cmd.Parameters.AddWithValue("@date", movie.Date);
                int RowCount = cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public string DeleteMovie(int movieid)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_deleteMovie", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MovieId", movieid);
            string delete = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return delete;
        }

    }
}
