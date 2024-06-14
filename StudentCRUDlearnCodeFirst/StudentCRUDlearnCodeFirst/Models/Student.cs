using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCRUDlearnCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set;}

        public string Name { get; set;}

        public string Gender { get; set;}

        public int Age { get; set;}

        // Constructor to initialize properties
        public Student()
        {
            // Initialize properties if needed
        }

        // Constructor to initialize properties with parameters
        public Student(int id, string name, string gender, int age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}