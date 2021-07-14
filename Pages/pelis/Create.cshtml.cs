using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.pelis
{
    public class CreateModel : PageModel
    {
        private readonly Razor.Data.RazorContext _context;

        public CreateModel(Razor.Data.RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Peli Peli { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Peli.Add(Peli);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
