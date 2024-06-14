using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Login_Signup.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        /*[EmailAddress(ErrorMessage = "Required w/ Format")]
        [Required(ErrorMessage = "Username is Required")]
        [DisplayName("USERNAME")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("PASSWORD")]
        [DataType(DataType.Password)]
        public string password { get; set; }*/
    }
}