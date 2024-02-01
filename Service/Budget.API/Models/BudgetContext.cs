using Microsoft.EntityFrameworkCore;

namespace Budget.Api.Models;

    public class BudgetContext : DbContext
{
    public BudgetContext(DbContextOptions<BudgetContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}
