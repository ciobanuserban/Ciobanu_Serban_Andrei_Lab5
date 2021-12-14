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
    public class IndexModel : PageModel
    {
        private readonly Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context _context;

        public IndexModel(Ciobanu_Serban_Andrei_Lab5.Data.Ciobanu_Serban_Andrei_Lab5Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; }
        public List<Book> Book { get; private set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();

        }
    }
}
