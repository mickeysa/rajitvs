﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace outsourcing.rajitservices.Models
{
    public class MailModel
    {
        [Required(ErrorMessage = "You must provide a First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must provide a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phone { get; set; }


        [Required(ErrorMessage = "You must provide a Message")]
        public string Message { get; set; }
        public HttpPostedFileBase Attachment { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
         
    }
}