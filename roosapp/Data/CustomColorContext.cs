using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class CustomColorContext : DbContext
    {
        public DbSet<CustomColor> CustomColors { get; set; }

        public CustomColorContext(DbContextOptions<CustomColorContext> options)
            : base(options) { }
    }
}
