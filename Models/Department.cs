using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Staff_Portal.Models
{
    public class Department // department class
    { 
        public int id { get; set; } // department id
        [Required] // link as a primery key 
        public string Department_Name { get; set; } // department name 

    }
}
