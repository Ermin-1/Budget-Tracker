using Budget_Tracker.Models;
using Microsoft.EntityFrameworkCore;


namespace Budget_Tracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    

    public DbSet<Category> Categories { get; set; }

   

    }
}
