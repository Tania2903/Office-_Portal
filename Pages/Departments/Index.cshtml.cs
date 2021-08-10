using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Office__Portal.Data;
using Staff_Portal.Models;

namespace Office__Portal.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly Office__Portal.Data.Office__PortalContext _context;

        public IndexModel(Office__Portal.Data.Office__PortalContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
