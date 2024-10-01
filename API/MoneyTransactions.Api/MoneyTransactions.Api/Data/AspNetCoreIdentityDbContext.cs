using Microsoft.EntityFrameworkCore;

namespace MoneyTransactions.Api.Data;

public class AspNetCoreIdentityDbContext : DbContext
{
    public AspNetCoreIdentityDbContext(DbContextOptions<AspNetCoreIdentityDbContext> options) : base(options)
    {
            
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}