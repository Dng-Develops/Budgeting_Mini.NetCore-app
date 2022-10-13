using Budgeting_App.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Budgeting_App.Models.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options){}

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
