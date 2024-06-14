using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppModels
{
    public class AddressModel
    {
        public int id { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public AddressModel Address { get; set; }
    }
}
