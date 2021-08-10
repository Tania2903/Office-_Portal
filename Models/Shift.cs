using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Staff_Portal.Models
{
    public class Shift  // shift class
    {
        public int id { get; set; }  //Shift idd
        public Staff Staff { get; set; } // Staff mender name 
        
        public int StaffID { get; set; }
        public Department Department { get; set; } // which department they doing shift
        
        public int DepartmentID { get; set; }
       
        public DateTime Date { get; set; }  // when Like date and time
        public int Total_Hours { get; set; } // how long is it

       





    }
}
