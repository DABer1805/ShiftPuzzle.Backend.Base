using Microsoft.EntityFrameworkCore;

public class CarpoolerContext : DbContext
{
 
    public CarpoolerContext(DbContextOptions<CarpoolerContext> options) : base(options)
    {
    }

    public DbSet<Carpooler> Carpooleres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
         modelBuilder.Entity<Carpooler>().HasKey(carpooler=>carpooler.ID);
    }
}