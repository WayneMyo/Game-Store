﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GameStore1.Models
{
    public class User
    {

        public string UserId { get; set; }

        [Key]
        // Use username as key
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        // [RegularExpression("([a-zA-Z]{1,})([@$!%*#?&]{1,})([0-9]{1,})")]
        public string Password { get; set; }

        //prints out an error message in the html page when user enters wrong user or password.
        public string LoginErrorMessage { get; set; }
    }
}
