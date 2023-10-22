using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab2._1.Models;

namespace Bruj_Tudor_Lab2._1.Data
{
    public class Bruj_Tudor_Lab2_1Context : DbContext
    {
        public Bruj_Tudor_Lab2_1Context (DbContextOptions<Bruj_Tudor_Lab2_1Context> options)
            : base(options)
        {
        }

        public DbSet<Bruj_Tudor_Lab2._1.Models.Book> Book { get; set; } = default!;

        public DbSet<Bruj_Tudor_Lab2._1.Models.Publisher>? Publisher { get; set; }
    }
}
