using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Models;
using MovieTicketBooking.DataAccess;
using Microsoft.AspNetCore.Http;

namespace MovieTicketBooking.Controllers
{
    public class MovieController : Controller
    {
        public List<MovieInfo> MovieList = new List<MovieInfo>();
        MovieDA MovieDAObj = new MovieDA();

        public IActionResult Home()
        {
            try
            {
                MovieList = MovieDAObj.GetMovies();
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                ViewData["message"] = logged;
                return View(MovieList);
            }
            catch (Exception exUserHome)
            {
                string exMessage = "oops! There is a problem in loading the home page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
           
        }
       
        public IActionResult MovieOnDate(string date )//Shows the lost of movies on a perticular date
        {
            try
            {
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                MovieList = MovieDAObj.MovieDate(date);
                return View(MovieList);
            }
            catch (Exception exMovieOnDate)
            {
                string exMessage = "oops! There is a problem in loading movies on the date.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
            
        }
   
        public IActionResult MovieDetails(int id)//shows the details of a perticular movie
        {
            try
            {
                MovieInfo movie = MovieDAObj.GetMovie(id);
                return View(movie);
            }
            catch (Exception exMovieDetails)
            {
                string exMessage = "oops! There is a problem in loading details of the movie.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
            
        }

        public IActionResult ChooseDate(int id,string name)//for selecting date after selecting movie
        {
            try
            {
                MovieInfo movie = new MovieInfo();
                movie.MovieID = id;
                movie.MovieName = name;
                return View(movie);
            }
            catch (Exception exChooseDate)
            {
                string exMessage = "oops! There is a problem in loading the page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
           
        }

        public IActionResult MovieShows(int movieId,string date)//Shows of movie
        {
            try
            {
                if (date == null)
                {
                    MovieList = MovieDAObj.shows(movieId);
                    int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                    ViewData["message"] = logged;
                    return View(MovieList);

                }
                else
                {
                    HttpContext.Session.SetInt32("MovieId", movieId);
                    HttpContext.Session.SetString("date", date);
                    int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                    MovieList = MovieDAObj.showsMovieDate(movieId, date);
                    ViewData["message1"] = date;
                    ViewData["message2"] = logged;
                    return View(MovieList);
                }
            }
            catch (Exception exMovieShow)
            {
                string exMessage = "oops! There is a problem in loading shows of the movie.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }


        [HttpGet]
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
