using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace ExtendedHomeHealthcare.Models
{
    public class EmailModel
    {
        [Required, Display(Name = "Your name")]
        public string Name { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string EmailAddress { get; set; }
        [Required, Display(Name = "Your Phone Number"), Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Message { get; set; }

    }
}