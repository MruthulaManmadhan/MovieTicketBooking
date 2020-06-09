using MovieTicketBooking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.DataAccess
{
    public class MovieDA
    {
        public string path = @"Data Source=MMANMADHAN01\SQLEXPRESS;Initial Catalog=MovieTicketBooking;Integrated Security=SSPI";

        public List<MovieInfo> GetMovies()
        {
            List<MovieInfo> MovieList = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_MovieList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    MovieInfo MovieObj = new MovieInfo();
                    MovieObj.MovieID = Convert.ToInt32(dr["MovieId"]);
                    MovieObj.MovieName = Convert.ToString(dr["MovieName"]);
                    MovieObj.Pic = Convert.ToString(dr["Poster"]);
                    MovieList.Add(MovieObj);
                }
            }
            return MovieList;
        }


        public List<MovieInfo> shows(int id)
        {
            List<MovieInfo> Shows = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_show", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    MovieInfo ShowObj = new MovieInfo();
                    ShowObj.MovieID = Convert.ToInt32(dr["MovieId"]);
                    ShowObj.MovieName = Convert.ToString(dr["MovieName"]);
                    ShowObj.TimeID = Convert.ToInt32(dr["ShowId"]);
                    ShowObj.Time = Convert.ToString(dr["Time"]);
                    ShowObj.AvailableSeats = Convert.ToInt32(dr["AvailableSeats"]);
                    ShowObj.Date = Convert.ToDateTime(dr["Date"]);
                    Shows.Add(ShowObj);
                }
            }
            return Shows;
        }


        public void Booking(int id, MovieTicket NewBook)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Booking", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", NewBook.TimeID);
            cmd.Parameters.AddWithValue("@seat", NewBook.NumberSeats);
            cmd.Parameters.AddWithValue("@userID", NewBook.UserID);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateSeat(int id,int seat)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_UpdateSeat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@seat",seat);

            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public MovieInfo GetMovie(int id)
        {
            MovieInfo Movie = new MovieInfo();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_MovieDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Movie.MovieID = Convert.ToInt32(dr["MovieId"]);
                    Movie.MovieName = Convert.ToString(dr["MovieName"]);
                    Movie.Pic = Convert.ToString(dr["Poster"]);
                    Movie.Director = Convert.ToString(dr["Director"]);
                    Movie.Actor = Convert.ToString(dr["Actor"]);
                    Movie.Release = Convert.ToDateTime( dr["Release"]);
                    Movie.Language = Convert.ToString(dr["Language"]);
                }
            }
            return Movie;
        }
        public List<MovieInfo> MovieDate(string date)
        {
            List<MovieInfo> OnDateList = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_SearchDate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    MovieInfo OnDate = new MovieInfo();
                    OnDate.MovieID = Convert.ToInt32(dr["MovieId"]);
                    OnDate.MovieName = Convert.ToString(dr["MovieName"]);
                    OnDate.Pic = Convert.ToString(dr["Poster"]);
                    OnDate.Date = Convert.ToDateTime(dr["Date"]);
                    OnDateList.Add(OnDate);
                }
            }
            return OnDateList;
        }
        public List<MovieInfo> showsMovieDate(int MovieId, string date)
        {
            List<MovieInfo> MovieDateList = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_SearchMovieDate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", MovieId);//data not fetched
                cmd.Parameters.AddWithValue("@date", date);//data not fetched
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    MovieInfo OnDate = new MovieInfo();
                    OnDate.MovieID = Convert.ToInt32(dr["MovieId"]);
                    OnDate.MovieName = Convert.ToString(dr["MovieName"]);
                    OnDate.Pic = Convert.ToString(dr["Poster"]);
                    OnDate.TimeID = Convert.ToInt32(dr["ShowId"]);
                    OnDate.Time = Convert.ToString(dr["Time"]);
                    OnDate.AvailableSeats = Convert.ToInt32(dr["AvailableSeats"]);
                    OnDate.Date = Convert.ToDateTime(dr["Date"]);
                    MovieDateList.Add(OnDate);
                }
            }
            return MovieDateList;
        }


        public List<MovieInfo> BookedList(int userid)
        {
            List<MovieInfo> Shows = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_BookedList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",userid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    MovieInfo ShowObj = new MovieInfo();
                    ShowObj.MovieName = Convert.ToString(dr["MovieName"]);
                    ShowObj.Time = Convert.ToString(dr["Time"]);
                    ShowObj.Seat = Convert.ToInt32(dr["NoOfSeats"]);
                    ShowObj.Date = Convert.ToDateTime(dr["Date"]);
                    ShowObj.BookID = Convert.ToInt32(dr["BookId"]);

                    Shows.Add(ShowObj);
                }
            }
            return Shows;
        }
        public void Cancel(int bookid,int seat)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Cancel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_id", bookid);
            cmd.Parameters.AddWithValue("@seat", seat);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public MovieInfo BookedMovie(int BookID)
        {
            MovieInfo ShowObj = new MovieInfo();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"sp_BookedMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bookid", BookID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ShowObj.MovieName = Convert.ToString(dr["MovieName"]);
                    ShowObj.Time = Convert.ToString(dr["Time"]);
                    ShowObj.Seat = Convert.ToInt32(dr["NoOfSeats"]);
                    ShowObj.Date = Convert.ToDateTime(dr["Date"]);
                    ShowObj.BookID = BookID;
                }
            }
            return ShowObj;
        }
    }
}
