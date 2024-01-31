using Microsoft.EntityFrameworkCore;

namespace Budget.Api.Models;

    public class BudgetContext : DbContext
{
    public TodoContext(DbContextOptions<BudgetContext> options)
        : base(options)
    {
    }

    public DbSet<User> UserEntries { get; set; } = null!;
}
