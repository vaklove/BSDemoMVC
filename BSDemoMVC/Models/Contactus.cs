using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BSDemoMVC.Models
{
    public class Contactus
    {
     
        [Required]
        public string Name { get; set;}
        [Required]
        
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Enter a vaild Email.")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}