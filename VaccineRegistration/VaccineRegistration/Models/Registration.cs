using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VaccineRegistration.Models
{
    public class Registration
    {
        [Required]
        public string firstname { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string phonenumber { get; set; }

        [Required]
        public string date { get; set; }

        [Required]
        public string blood { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        [Compare("password")]
        public string conpassword { get; set; }
    }
}