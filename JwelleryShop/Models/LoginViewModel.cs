﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JwelleryShop.Models
{
    public class LoginViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
    }
}