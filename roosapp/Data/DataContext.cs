using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CustomColor> CustomColors { get; set; }
}
