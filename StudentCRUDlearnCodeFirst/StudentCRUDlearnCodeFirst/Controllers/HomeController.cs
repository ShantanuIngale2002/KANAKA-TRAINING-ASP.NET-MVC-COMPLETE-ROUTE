using StudentCRUDlearnCodeFirst.Data;
using StudentCRUDlearnCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace StudentCRUDlearnCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentContext"].ToString());
        // GET: Home
        public ActionResult Index()
        {
            var data=db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(s);
                int rows = db.SaveChanges();

                /*string query = "INSERT INTO [dbo].[Students] VALUES(@name, @gender, @age)";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@name",s.Name);
                cmd.Parameters.AddWithValue("@gender",s.Gender);
                cmd.Parameters.AddWithValue("@age",s.Age);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();*/

                if (rows > 0)
                {
                    ViewBag.InsertMessage = "<script> alert('Data Inserted !!') </script>";
                }
                else
                {
                    ViewBag.InsertMessage = "<script> alert('Data not Inserted !!') </script>";
                }
            }
            
            return View();
        }



        public ActionResult Edit(int id)
        {
            var rows = db.Students.Where(model=>model.Id == id).FirstOrDefault();

            /*string query = "SELECT * FROM [dbo].[Students] WHERE [dbo].[Students].Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Student stud = new Student((int)reader["Id"], (string)reader["Name"], (string)reader["Gender"], (int)reader["Age"]);
                return View(stud);
            }
            conn.Close();*/

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                int rows = db.SaveChanges();

                /*string query = "UPDATE [dbo].[Students] SET Name=@name, Gender=@gender, Age=@age WHERE [dbo].[Students].id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", s.Name);
                cmd.Parameters.AddWithValue("@gender", s.Gender);
                cmd.Parameters.AddWithValue("@age", s.Age);
                cmd.Parameters.AddWithValue("@id", s.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();*/

                if (rows > 0)
                {
                    ViewBag.UpdateMsg = "<script> alert('Data Updated !!') </script>";
                }
                else
                {
                    ViewBag.UpdateMsg = "<script> alert('Data not Updated !!') </script>";
                }
            }
            return View();
        }




        public ActionResult Details(int id)
        {
            /*string query = "SELECT * FROM [dbo].[Students] WHERE [dbo].[Students].Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Student stud = new Student((int)reader["Id"], (string)reader["Name"], (string)reader["Gender"], (int)reader["Age"]);
                return View(stud);
            }
            conn.Close();*/

            var rows = db.Students.Where(model=>model.Id == id).FirstOrDefault();
            return View(rows);
        }





        public ActionResult Delete(int id)
        {

            /*string query = "SELECT * FROM [dbo].[Students] WHERE [dbo].[Students].Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Student stud = new Student((int)reader["Id"], (string)reader["Name"], (string)reader["Gender"], (int)reader["Age"]);
                return View(stud);
            }
            conn.Close();*/

            var rows = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(rows);
        }

        [HttpPost]
        public ActionResult Delete(Student s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
                int rows = db.SaveChanges();

                /*string query = "DELETE FROM [dbo].[Students] WHERE [dbo].[Students].id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", s.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();*/


                if (rows > 0)
                {
                    ViewBag.DeleteMsg = "<script> alert('Data Deleted !!') </script>";
                }
                else
                {
                    ViewBag.DeleteMsg = "<script> alert('Data not Deleted !!') </script>";
                }
            }
            return View();
        }
    }
}