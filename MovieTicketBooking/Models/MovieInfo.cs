using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class MovieInfo
    {
        public int MovieID { get; set; }

        //[Required(ErrorMessage = "Movie name is required")]
        public string MovieName { get; set; }

        //[Required(ErrorMessage = "Poster is required")]
        public string Pic { get; set; }
        [Display(Name = "Film Director")]

        //[Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        //[Required(ErrorMessage = "Actor is required")]
        public string Actor { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        //[Required(ErrorMessage = "Release date is required")]
        public DateTime Release { get; set; }

        //[Required(ErrorMessage = "Language is required")]
        public string Language { get; set; }
        public int TimeID { get; set; }

        //[Required(ErrorMessage = "Time is required")]
        public string Time { get; set; }
        [Display(Name = "Available Seats")]

        //[Required(ErrorMessage = "Available seat is required")]
        public int AvailableSeats { get; set; }

       // [Required(ErrorMessage = "Date is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        //[Required(ErrorMessage = "Number of seat is required")]
        public int Seat { get; set; }
        public int BookID { get; set; }

    }
}
