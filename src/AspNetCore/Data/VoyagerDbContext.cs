using AspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Data
{
    public class VoyagerDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public VoyagerDbContext(DbContextOptions options) :
            base(options)
        { }
    }
}
