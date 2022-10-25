using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tomi_Lavinia_Lab2.Models;

namespace Tomi_Lavinia_Lab2.Data
{
    public class Tomi_Lavinia_Lab2Context : DbContext
    {
        public Tomi_Lavinia_Lab2Context (DbContextOptions<Tomi_Lavinia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tomi_Lavinia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Tomi_Lavinia_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Tomi_Lavinia_Lab2.Models.Author> Author { get; set; }

        public DbSet<Tomi_Lavinia_Lab2.Models.Category> Category { get; set; }
    }
}
