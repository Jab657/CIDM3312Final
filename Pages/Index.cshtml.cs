using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312Final.Models;

namespace CIDM3312Final.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CIDM3312Final.Models.AppDbContext _context;

        public IndexModel(CIDM3312Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Games { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Games = await _context.Games.Include(p => p.Characters).ToListAsync();
        }
    }
}