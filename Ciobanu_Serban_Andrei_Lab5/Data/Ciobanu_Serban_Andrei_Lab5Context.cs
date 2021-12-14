using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciobanu_Serban_Andrei_Lab5.Models;

namespace Ciobanu_Serban_Andrei_Lab5.Data
{
    public class Ciobanu_Serban_Andrei_Lab5Context : DbContext
    {
        public Ciobanu_Serban_Andrei_Lab5Context (DbContextOptions<Ciobanu_Serban_Andrei_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Ciobanu_Serban_Andrei_Lab5.Models.Book> Book { get; set; }

        public DbSet<Ciobanu_Serban_Andrei_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Ciobanu_Serban_Andrei_Lab5.Models.Category> Category { get; set; }
    }
}
