﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.ViewModels
{
    public class LoginViewModel
    {

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}