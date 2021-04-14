using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
namespace TheSims.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Sim> Sims { get; set; }
        public DbSet<DomesticUnit> DomesticUnits { get; set;}
    }
}