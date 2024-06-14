using Bank_LoginSignupHome.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bank_LoginSignupHome.Data
{
    public class LoginContext : DbContext
    {
        public DbSet<LoginModel> LoginModels { get; set; }
    }
}