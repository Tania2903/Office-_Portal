using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Staff_Portal.Models
{
    public class Staff // staff class 
    { 
        public int id { get; set; } // staff id 
        [Required]
        public string First_Name { get; set; } // fisrt name
        public string Last_Name { get; set; } // last name

        public string Address { get; set; } // staff residentail address
        public string Email { get; set; } // staff email address


        public int Phone { get; set; } // Staff phone details


    }
}
