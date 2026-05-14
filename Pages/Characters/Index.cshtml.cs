using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312Final.Models;

namespace CIDM3312Final.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly CIDM3312Final.Models.AppDbContext _context;

        public IndexModel(CIDM3312Final.Models.AppDbContext context)
        {
            _context = context;
        }
        public IList<Character> Character { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            // var query = _context.Characters.Include(g => g.GameCharacters!).ThenInclude(cg => cg.Game).Select(g => g);
            var query = _context.Characters.Include(g => g.Game!).Select(g => g);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(g => g.CharacterName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(g => g.CharacterName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(g => g.CharacterName);
                    break;
            }

            TotalPages = (int)Math.Ceiling(_context.Characters.Count() / (double)PageSize);
            
            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
              
        }
    }
}
