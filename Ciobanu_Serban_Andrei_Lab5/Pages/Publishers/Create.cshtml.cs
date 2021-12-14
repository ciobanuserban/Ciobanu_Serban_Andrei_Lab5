using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ciobanu_Serban_Andrei_Lab5.Data;
using Ciobanu_Serban_Andrei_Lab5.Models;

namespace Ciobanu_Serban_Andrei_Lab5.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context _context;

        public CreateModel(Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
