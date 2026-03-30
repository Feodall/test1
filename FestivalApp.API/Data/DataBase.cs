using Microsoft.EntityFrameworkCore;
using SampleApp.API.Entities;

namespace SampleApp.API.Data;

public class SampleAppContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Competence> Competences { get; set; }
    public DbSet<Region> Regions { get; set; }

    public SampleAppContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=192.168.4.90;Port=5432;Database=10ip215;Username=10ip215;Password=10ip215");
    }


}