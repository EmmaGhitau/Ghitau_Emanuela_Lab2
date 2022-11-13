using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghitau_Emanuela_Lab2.Models;

namespace Ghitau_Emanuela_Lab2.Data
{
    public class Ghitau_Emanuela_Lab2Context : DbContext
    {
        public Ghitau_Emanuela_Lab2Context (DbContextOptions<Ghitau_Emanuela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ghitau_Emanuela_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
