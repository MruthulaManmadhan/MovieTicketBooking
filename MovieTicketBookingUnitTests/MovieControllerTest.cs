using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Mobile.Server.Controllers;
using MovieTicketBooking.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MovieTicketBooking.DataAccess;
using MovieTicketBooking.Models;

namespace MovieTicketBookingUnitTests
{
    class MovieControllerTest
    {
        [Test]
        public void Home()
        {
            MovieController controller = new MovieController(new MokeMovieDA);
            ViewResult result = controller.Home() as ViewResult;
            Assert.IsNotNull(result);
        }
        class MokeMovieDA : MovieDA
        {
            public MovieInfo[] Movies = { new MovieInfo{ MovieID = 1, MovieName = "luttapi", Pic = "NoImage" } };
            public MovieInfo[] GetMovie()
            {
                return Movies;
            }
        }
    }
}
