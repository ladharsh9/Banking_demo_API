using Banking_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Banking_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        
             public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    
    }
}
