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


        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        public IndexModel(CIDM3312Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {

            TotalPages = (int)Math.Ceiling(_context.Games.Count() / (double)PageSize);
            
            Character = await _context.Characters.Include(g => g.Game)
            .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
              
        }
    }
}
