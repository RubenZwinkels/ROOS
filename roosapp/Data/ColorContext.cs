using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class ColorContext : DbContext
    {
        public DbSet<Color> Colors { get; set; }

        public ColorContext(DbContextOptions<ColorContext> options)
            : base(options) { }
    }
}
