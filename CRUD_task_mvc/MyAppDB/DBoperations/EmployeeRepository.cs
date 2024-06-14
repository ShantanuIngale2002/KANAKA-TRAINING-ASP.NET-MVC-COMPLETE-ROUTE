using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppModels;

namespace MyAppDB.DBoperations
{
    public class EmployeeRepository
    {
        public int addEmployee(EmployeeModel model)
        {
            // using "using" keyword after complition of its code block it will delete/clear var space.
            using(var context = new EmployeeDBEntities())
            {
                empTable01 emp = new empTable01()
                {
                    fname = model.fname,
                    lname = model.lname,
                    email = model.email,
                    empid = model.empid
                };

                context.empTable01.Add(emp);
                context.SaveChangesAsync();

                return emp.id;
            }
        }
    }
}
