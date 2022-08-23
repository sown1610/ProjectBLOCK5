using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBLOCK5.Models;

namespace ProjectBLOCK5.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly ProjectBLOCK5.Models.CenimaDBContext _context;

        public DetailsModel(ProjectBLOCK5.Models.CenimaDBContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies
                .Include(m => m.Genre).FirstOrDefaultAsync(m => m.MovieId == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
