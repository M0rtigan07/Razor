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
    public class IndexModel : PageModel
    {
        private readonly Razor.Data.RazorContext _context;

        public IndexModel(Razor.Data.RazorContext context)
        {
            _context = context;
        }

        public IList<Peli> Peli { get;set; }

        public async Task OnGetAsync()
        {
            Peli = await _context.Peli.ToListAsync();
        }
    }
}
