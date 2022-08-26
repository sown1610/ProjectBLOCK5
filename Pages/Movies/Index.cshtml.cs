using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBLOCK5.Models;
using Microsoft.AspNetCore.Http;

namespace ProjectBLOCK5.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ProjectBLOCK5.Models.CenimaDBContext _context;

        public IndexModel(ProjectBLOCK5.Models.CenimaDBContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("account") == null)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                Movie = _context.Movies
                .Include(m => m.Genre).ToList();
                return Page();
            }
            
        }
    }
}
