using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBLOCK5.Models;

namespace ProjectBLOCK5.Pages.Genres
{
    public class IndexModel : PageModel
    {
        private readonly ProjectBLOCK5.Models.CenimaDBContext _context;

        public IndexModel(ProjectBLOCK5.Models.CenimaDBContext context)
        {
            _context = context;
        }

        public IList<Genre> Genre { get;set; }

        public async Task OnGetAsync()
        {
            Genre = await _context.Genres.ToListAsync();
        }
    }
}
