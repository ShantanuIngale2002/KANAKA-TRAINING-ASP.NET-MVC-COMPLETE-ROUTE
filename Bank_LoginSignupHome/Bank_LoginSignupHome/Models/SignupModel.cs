using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bank_LoginSignupHome.Models
{
    public class SignupModel
    {
        public int AccountNumber {  get; set; }
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "AddressPincode is Required")]
        public string AddressPincode { get; set; }

        [Required(ErrorMessage = "Contact is Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Inappropriate Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Inappropritate Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}