using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class PlaceContext : DbContext
    {
        public DbSet<Place> Places { get; set; }

        public PlaceContext(DbContextOptions<PlaceContext> options)
            : base(options) { }
    }
}
