using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Login_Signup.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Login_Signup.Data
{
    public class SignupContext : DbContext
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender Name is required")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [DisplayName("Age")]
        [Range(0, 100, ErrorMessage ="Inappropriate Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Username")]
        [EmailAddress(ErrorMessage ="Inappropriate Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pin Code is required")]
        [DisplayName("Pin Code")]
        [Range(0, 999999, ErrorMessage = "Pin code error")]
        public int PinCode { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password",ErrorMessage ="Inappropriate Password")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public DbSet<SignupModel> User {  get; set; }
    }
}