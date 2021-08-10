using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Office__Portal.Data;
using Staff_Portal.Models;

namespace Office__Portal.Pages.Shifts
{
    public class EditModel : PageModel
    {
        private readonly Office__Portal.Data.Office__PortalContext _context;

        public EditModel(Office__Portal.Data.Office__PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["DepartmentID"] = new SelectList(_context.Department, "id", "Department_Name");
           ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "id", "First_Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Shift).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftExists(Shift.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShiftExists(int id)
        {
            return _context.Shift.Any(e => e.id == id);
        }
    }
}
