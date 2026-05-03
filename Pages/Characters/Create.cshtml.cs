using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312Final.Models;

namespace CIDM3312Final.Pages.Characters
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312Final.Models.AppDbContext _context;

        public CreateModel(CIDM3312Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GameID"] = new SelectList(_context.Games, "GameID", "GameID");
            return Page();
        }

        [BindProperty]
        public Character Character { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Characters.Add(Character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
