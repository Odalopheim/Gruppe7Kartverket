using Microsoft.EntityFrameworkCore;
namespace Gruppe7Kartverket.Data;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
      
   }
   public DbSet<GeoChange> GeoChanges { get; set; }
    
}