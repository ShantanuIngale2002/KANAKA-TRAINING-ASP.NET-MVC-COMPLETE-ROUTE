using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bank_LoginSignupHome.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Email is Required")]
        [EmailAddress(ErrorMessage="Inappropriate Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int userId {  get; set; }
    }
}