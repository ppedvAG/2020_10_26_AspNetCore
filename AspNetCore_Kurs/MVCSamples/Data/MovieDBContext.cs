using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCSamples.Models;

namespace MVCSamples.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext (DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVCSamples.Models.Movie> Movie { get; set; }
        public DbSet<MVCSamples.Models.Artist> Artist { get; set; }
    }
}
