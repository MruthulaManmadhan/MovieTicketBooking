using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.DataAccess;
using MovieTicketBooking.Models;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace MovieTicketBooking.Controllers
{
    public class AdminController : Controller
    {
        AdminDA adminDAObj = new AdminDA();
        public IActionResult Home()
        {
            try
            {
                return RedirectToAction("Login", "User");
            }
            catch(Exception exAdmin)
            {
                string exMessage = "oops! There is a problem in loading the home page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        public IActionResult AddOrRemove(string message)
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    ViewBag.message = message;
                    return View();
                }
                else
                {
                    return RedirectToAction("Home", "Movie");
                }
            }
            catch (Exception exAdminHome)
            {
                string exMessage = "oops! There is a problem in loading the home page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpGet]
        public IActionResult AddShow()
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Home", "Movie");
                }
            }
            catch (Exception exAddShowPage)
            {
                string exMessage = "oops! There is a problem in loading the page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpPost]
        public IActionResult AddShow(MovieInfo movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                    if (admin == 1)
                    {
                        adminDAObj.AddShow(movie);
                        string success = "Movie added successfully";
                        return View("AddOrRemove", new { message = success });
                    }
                    else
                    {
                        return RedirectToAction("Home", "Movie");
                    }
                }
                catch (Exception exAddShow)
                {
                    string exMessage = "oops! There is a problem in adding the movie.";
                    return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult MovieList(string message)
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    List<MovieInfo> movies = new List<MovieInfo>();
                    MovieDA MovieDAObj = new MovieDA();
                    movies = MovieDAObj.GetMovies();
                    ViewBag.message = message;
                    return View(movies);
                }
                else
                {
                    return RedirectToAction("Home", "Movie");
                }
            }
            catch (Exception exRemoveShow)
            {
                string exMessage = "oops! There is a problem in loading the page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpGet]
        public IActionResult RemoveMovie(int movieid)//for canceling the Movie
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    MovieDA movieDAObj = new MovieDA();
                    MovieInfo movie = new MovieInfo();
                    movie = movieDAObj.GetMovie(movieid);
                    return View(movie);
                }
                else
                    return RedirectToAction("Home","Movie");
            }
            catch (Exception exCancelConfirmation)
            {
                string exMessage = "oops! There is a problem in loading the page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }

        }
        [HttpPost]
        public IActionResult RemoveMovie(MovieInfo movie)
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    string delete= adminDAObj.DeleteMovie(movie.MovieID);
                    string success;
                    if (delete == "YES")
                    {
                         success = "Movie Deleted successfully";
                    }
                    else
                    {
                        success = "Cannot delete the movie. Seats Booked";
                    }
                    return RedirectToAction("MovieList", "Admin", new { message = success });
                }
                else
                {
                    return RedirectToAction("Home","Movie");
                }
            }
            catch (Exception exDeleteMovie)
            {
                string exMessage = "oops! There is a problem in deleting your movie.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }

        }

        public IActionResult Logout()
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    HttpContext.Session.SetInt32("Logged", 0);
                    HttpContext.Session.SetInt32("Admin", 0);
                }
                return RedirectToAction("Home", "Movie");
            }
            catch (Exception exLogout)
            {
                string exMessage = "oops! There is a problem in loggingout.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpGet]
        public IActionResult Test()
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));
                if (admin == 1)
                {
                    return View();
                }
                return RedirectToAction("Home", "Movie");
            }
            catch (Exception exTest)
            {
                string exMessage = "oops! There is a problem in TestGet.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpPost]
        public IActionResult Test(Test images)
        {
            try
            {
                int admin = Convert.ToInt32(HttpContext.Session.GetInt32("Admin"));

                if (admin == 1)
                {
                    //using (Image image = Image.FromFile(Path))
                    //{
                    Image image = images.Poster;
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        string base64String = Convert.ToBase64String(imageBytes);
                        ViewData["message"] = base64String;
                        return View("ShowImage");
                    }
                    //}


                    //string Image = Convert.ToBase64String(File.ReadAllBytes(Path));
                    //ViewData["message"] = Image;
                    // return View("ShowImage");
                }
                return RedirectToAction("Home", "Movie");
            }
            catch (Exception exLogout)
            {
                string exMessage = "oops! There is a problem in testing.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }

    }
}