using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Staff_Portal.Models;

namespace Office__Portal.Data
{
    public class Office__PortalContext : DbContext
    {
        public Office__PortalContext (DbContextOptions<Office__PortalContext> options)
            : base(options)
        {
        }

        public DbSet<Staff_Portal.Models.Department> Department { get; set; }

        public DbSet<Staff_Portal.Models.Shift> Shift { get; set; }

        public DbSet<Staff_Portal.Models.Staff> Staff { get; set; }
    }
}
