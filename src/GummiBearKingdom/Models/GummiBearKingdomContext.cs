using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public GummiBearKingdomContext(DbContextOptions<GummiBearKingdomContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
