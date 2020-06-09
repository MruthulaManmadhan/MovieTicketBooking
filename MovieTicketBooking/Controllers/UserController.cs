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
    public class UserController : Controller
    {
        UserDA UserDAObj = new UserDA();

        public IActionResult Login(int id, int seat)
        {
            try
            {
                if (id != 0)
                {
                    HttpContext.Session.SetInt32("TimeID", id);
                    HttpContext.Session.SetInt32("seat", seat);
                }
                ViewData["message"] = id;
                return View();
            }
            catch (Exception exLoginPage)
            {
                string exMessage = "oops! There is a problem in loading login page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpPost]
        public IActionResult Login(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int Role = UserDAObj.Login(user.Mobile, user.Password);
                    if (Role != 0)
                    {
                        HttpContext.Session.SetInt32("Logged", 1);
                        if (Role == 1)
                        {
                            HttpContext.Session.SetInt32("Admin", 1);
                            return RedirectToAction("MovieList", "Admin");
                        }
                        else
                        {
                            var id = HttpContext.Session.GetInt32("TimeID");
                            var seat = HttpContext.Session.GetInt32("seat");
                            UserInfo User = UserDAObj.Search(user);
                            HttpContext.Session.SetString("UserName", User.Name);
                            HttpContext.Session.SetInt32("UserID", User.UserID);
                            if (id != null && seat != null)
                            {
                                int movieId = Convert.ToInt32(HttpContext.Session.GetInt32("MovieId"));
                                string date = Convert.ToString(HttpContext.Session.GetString("date"));
                                return RedirectToAction("BookSeat", "Booking", new { @MovieId = movieId, @date = date });
                            }
                            return RedirectToAction("Home", "Movie");
                        }
                    }
                    else
                    {
                        ViewBag.NotValidUser = "Invalid User";
                        return View();
                    }

                }
                catch (Exception exLogin)
                {
                    string exMessage = "oops! There is a problem in login.";
                    return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
                }
            }
            else
            {
                return View();
            }
               
        }
        [HttpGet]
        public IActionResult SignUp(string userExist)
        {
            try
            {
                return View();
            }
            catch (Exception exSignupPage)
            {
                string exMessage = "oops! There is a problem in loading signup page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpPost]
        public IActionResult SignUp(UserInfo user)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    if (ModelState.IsValid)
                    {
                        string isNewUser = UserDAObj.IsNewUser(user.Mobile);
                        if (isNewUser != "Yes")
                        {
                            UserInfo User = UserDAObj.SignUp(user);
                            HttpContext.Session.SetInt32("Logged", 1);
                            var id = HttpContext.Session.GetInt32("TimeID");
                            var seat = HttpContext.Session.GetInt32("seat");
                            HttpContext.Session.SetString("UserName", user.Name);
                            HttpContext.Session.SetInt32("UserID", User.UserID);
                            if (id != null && seat != null)
                            {
                                int movieId = Convert.ToInt32(HttpContext.Session.GetInt32("MovieId"));
                                string date = Convert.ToString(HttpContext.Session.GetString("date"));
                                return RedirectToAction("MovieShowsOndate", "Movie", new { @MovieId = movieId, @date = date });
                            }
                            return RedirectToAction("Home","Movie");
                        }
                        else
                        {
                            string UserExist = "User Exist";
                            ViewBag.user = UserExist;
                            return View();
                        }
                    }
                    else
                    {
                        return View();
                    }
                }
                catch (Exception exSignup)
                {
                    string exMessage = "oops! There is a problem in signing up.";
                    return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
                }
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Logout()
        {
            try
            {
                HttpContext.Session.SetInt32("Logged", 0);
                return RedirectToAction("Home","Movie");
            }
            catch (Exception exUserLogout)
            {
                string exMessage = "oops! There is a problem in loggingout.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
           
        }
    }
}