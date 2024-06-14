using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bank_LoginSignupHome.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank_LoginSignupHome.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}