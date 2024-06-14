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
    public class LoginContext : DbContext
    {
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Required w/ Format")]
        [Required(ErrorMessage = "Username is Required")]
        [DisplayName("Username")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [DisplayName("PASSWORD")]
        public string Password { get; set; }

        public DbSet<LoginModel> User { get; set; }
    }
}