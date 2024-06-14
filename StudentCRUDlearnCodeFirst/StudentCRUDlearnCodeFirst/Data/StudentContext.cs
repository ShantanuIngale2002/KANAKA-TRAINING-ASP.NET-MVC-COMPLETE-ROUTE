using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudentCRUDlearnCodeFirst.Models;

namespace StudentCRUDlearnCodeFirst.Data
{
    public class StudentContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}