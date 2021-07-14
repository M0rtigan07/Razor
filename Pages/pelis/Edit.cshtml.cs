using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.pelis
{
    public class EditModel : PageModel
    {
        private readonly Razor.Data.RazorContext _context;

        public EditModel(Razor.Data.RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Peli Peli { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Peli = await _context.Peli.FirstOrDefaultAsync(m => m.ID == id);

            if (Peli == null)
            {
                return NotFound();
            }
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

            _context.Attach(Peli).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeliExists(Peli.ID))
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

        private bool PeliExists(int id)
        {
            return _context.Peli.Any(e => e.ID == id);
        }
    }
}
