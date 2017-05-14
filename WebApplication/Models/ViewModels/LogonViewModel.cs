using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models.ViewModels
{
    public class LogonViewModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件(Email)")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼(Password)")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "請輸入4-20位數")]
        public string Password { get; set; }

        public string Message { get; set; }
        
    }
}