using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Models;
using MovieTicketBooking.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace MovieTicketBooking.Controllers
{
    public class BookingController : Controller
    {
        MovieDA MovieDAObj = new MovieDA();
        public List<MovieInfo> MovieList = new List<MovieInfo>();
        public IActionResult BookSeat(int id, int seat)//page for getting the number of seats to be booked
        {
            try
            {
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                if (logged == 1)
                {
                    if (id != 0)
                    {
                        HttpContext.Session.SetInt32("TimeID", id);
                    }
                    var Seat = HttpContext.Session.GetInt32("seat");
                    ViewData["message"] = Seat;// passing number of available seats to view for limiting booking 
                    return View();
                }
                else
                    return RedirectToAction("Home","Movie");
            }
            catch (Exception exBookSeatPage)
            {
                string exMessage = "oops! There is a problem in loading the page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpPost]
        public IActionResult BookSeat(MovieTicket newBook)//booking the number of seats
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                    if (logged == 1)
                    {
                        var id = Convert.ToInt32(HttpContext.Session.GetInt32("TimeID"));
                        var name = HttpContext.Session.GetString("UserName");
                        var userID = HttpContext.Session.GetInt32("UserID");
                        newBook.UserID = Convert.ToInt32(userID);
                        newBook.TimeID = id;
                        newBook.Name = Convert.ToString(name);
                        MovieDAObj.Booking(id, newBook);
                        MovieDAObj.UpdateSeat(id, newBook.NumberSeats);
                        string success = "Ticket booked successfully";
                        //ViewBag.message= success;
                        return RedirectToAction("BookHistory", "Booking", new { message = success });
                    }
                    else
                        return RedirectToAction("Home", "Movie");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception exBookSeat)
            {
                string exMessage = "oops! There is a problem in booking your tickets.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        public IActionResult BookHistory(string message)// for showing the booking history of a user
        {
            try
            {
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                if (logged == 1)
                {
                    int userID = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));
                    MovieList = MovieDAObj.BookedList(userID);
                    ViewBag.message = message;
                    return View(MovieList);
                }
                else
                    return RedirectToAction("Home","Movie");
            }
            catch (Exception exBookHistory)
            {
                string exMessage = "oops! There is a problem in loading your booking history page.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
        }
        [HttpGet]
        public IActionResult CancelBooking(int bookId)//for canceling the booking
        {
            try
            {
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                if (logged == 1)
                {
                    MovieInfo movie = new MovieInfo();
                    movie = MovieDAObj.BookedMovie(bookId);
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
        public IActionResult CancelBooking(MovieInfo movie)
        {
            try
            {
                int logged = Convert.ToInt32(HttpContext.Session.GetInt32("Logged"));
                if (logged == 1)
                {
                    MovieDAObj.Cancel(movie.BookID, movie.Seat);
                    string success = "Ticket cancelled successfully";
                    return RedirectToAction("BookHistory", "Booking", new { message = success });
                }
                else
                {
                    return RedirectToAction("Home","Movie");
                }
            }
            catch (Exception exCancelTicket)
            {
                string exMessage = "oops! There is a problem in canceling your tickets.";
                return RedirectToAction("Index", "ExeptionHandler", new { Exeption = exMessage });
            }
            
        }
    }
}