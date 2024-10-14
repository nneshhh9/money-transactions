using Microsoft.EntityFrameworkCore;

namespace MoneyTransactions.Api.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext
{
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<User> Users { get; set; }
}