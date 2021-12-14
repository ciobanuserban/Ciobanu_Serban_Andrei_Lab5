using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciobanu_Serban_Andrei_Lab5.Data;
using Ciobanu_Serban_Andrei_Lab5.Models;

namespace Ciobanu_Serban_Andrei_Lab5.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context _context;

        public DeleteModel(Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FindAsync(id);

            if (Publisher != null)
            {
                _context.Publisher.Remove(Publisher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
