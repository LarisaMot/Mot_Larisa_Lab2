using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mot_Larisa_Lab2.Models;

namespace Mot_Larisa_Lab2.Data
{
    public class Mot_Larisa_Lab2Context : DbContext
    {
        public Mot_Larisa_Lab2Context (DbContextOptions<Mot_Larisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mot_Larisa_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mot_Larisa_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
