using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Office__Portal.Data;
using Staff_Portal.Models;

namespace Office__Portal.Pages.Shifts
{
    public class DetailsModel : PageModel
    {
        private readonly Office__Portal.Data.Office__PortalContext _context;

        public DetailsModel(Office__Portal.Data.Office__PortalContext context)
        {
            _context = context;
        }

        public Shift Shift { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shift = await _context.Shift
                .Include(s => s.Department)
                .Include(s => s.Staff).FirstOrDefaultAsync(m => m.id == id);

            if (Shift == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
