using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Liscence> Liscences { get; set; }
    public DbSet<EngineerLiscence> EngineerLiscences { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }

  }
}