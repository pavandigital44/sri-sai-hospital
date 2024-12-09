using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSH.Web.Models
{
    public class EmailModel
    {
        public int EmailId { get; set; } 
        public string Name { get; set; } 
        [Required (ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
        public string Message { get; set; } 
        public string Subject { get; set; }
        public string PhoneNo { get; set; }
        public string City { get; set; }
        public string FormName { get; set; }
    }
}