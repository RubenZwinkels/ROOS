using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public TransactionContext(DbContextOptions<TransactionContext> options)
            : base(options) { }
    }
}
