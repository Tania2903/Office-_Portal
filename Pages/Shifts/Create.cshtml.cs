using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Office__Portal.Data;
using Staff_Portal.Models;

namespace Office__Portal.Pages.Shifts
{
    public class CreateModel : PageModel
    {
        private readonly Office__Portal.Data.Office__PortalContext _context;

        public CreateModel(Office__Portal.Data.Office__PortalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartmentID"] = new SelectList(_context.Department, "id", "Department_Name");
        ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "id", "First_Name");
            return Page();
        }

        [BindProperty]
        public Shift Shift { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shift.Add(Shift);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
