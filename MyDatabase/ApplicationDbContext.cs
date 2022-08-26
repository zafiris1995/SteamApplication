using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    internal class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext() : base("Sindesmos")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
