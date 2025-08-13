using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public CategoryContext(DbContextOptions<CategoryContext> options)
            : base(options) { }
    }
}
