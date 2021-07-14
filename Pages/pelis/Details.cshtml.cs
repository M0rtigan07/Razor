using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.pelis
{
    public class DetailsModel : PageModel
    {
        private readonly Razor.Data.RazorContext _context;

        public DetailsModel(Razor.Data.RazorContext context)
        {
            _context = context;
        }

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
    }
}
