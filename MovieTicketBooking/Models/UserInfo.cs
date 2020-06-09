﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public int Role { get; set; }
        //[Required(ErrorMessage = "UserName is required")]
        public string Name { get; set; }
       // [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile number is required"),MaxLength(10)]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
