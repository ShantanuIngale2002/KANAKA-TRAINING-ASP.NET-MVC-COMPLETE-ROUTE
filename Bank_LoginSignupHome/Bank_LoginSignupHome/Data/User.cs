using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bank_LoginSignupHome.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string AddressPincode { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}