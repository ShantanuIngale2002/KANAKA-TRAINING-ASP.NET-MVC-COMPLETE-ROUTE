using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyAppModels
{
    public class EmployeeModel
    {
        public int id { get; set; }

        [Required]
        public string fname { get; set; }
        public string lname { get; set; }
        [EmailAddress, Required]
        public string email { get; set; }
        [Required]
        public Nullable<int> addressid { get; set; }
        [Required]
        public Nullable<int> empid { get; set; }


        public AddressModel Address { get; set; }
    }
}
