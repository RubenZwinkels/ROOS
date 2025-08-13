using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class TagContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }

        public TagContext(DbContextOptions<TagContext> options)
            : base(options) { }
    }
}
