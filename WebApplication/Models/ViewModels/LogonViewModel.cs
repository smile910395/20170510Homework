﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models.ViewModels
{
    public class LogonViewModel
    {
        
        
        public string Account { get; set; }

        public string Password { get; set; }

        public string Message { get; set; }
        
    }
}