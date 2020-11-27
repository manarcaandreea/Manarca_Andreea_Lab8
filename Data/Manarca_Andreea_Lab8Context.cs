using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manarca_Andreea_Lab8.Models;

namespace Manarca_Andreea_Lab8.Data
{
    public class Manarca_Andreea_Lab8Context : DbContext
    {
        public Manarca_Andreea_Lab8Context (DbContextOptions<Manarca_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Manarca_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Manarca_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Manarca_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
