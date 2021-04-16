using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using TheSims.Models.Relations;
namespace TheSims.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Sim> Sims { get; set; }
        public DbSet<DomesticUnit> DomesticUnits { get; set;}
        public DbSet<Action> Actions { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<World> Worlds { get; set; }
   
        
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Involve> Involvements { get; set; }
        public DbSet<Perform> Performances { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<NeighborhoodDomesticUnits> NeighborhoodDomesticUnitsTable { get; set; }
        public DbSet<NeighborhoodPlaces> NeighborhoodPlacesTable { get; set; }
        public DbSet<ProfessionUpgradesSkill> ProfessionUpgradesSkillsTable { get; set; }
        public DbSet<PetLives> PetLivesTable { get; set; }
        public DbSet<SimLives> SimLivesTable { get; set; }
        public DbSet<SimSkills> SimSkillsTable { get; set; }
        public DbSet<SkillActions> SkillActionsTable { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .HasKey(m => new { m.SimID, m.ProfessionID });
                
            modelBuilder.Entity<Involve>().HasKey(m => new { m.SimID, m.Date,m.QuestID,m.WorldID });
            modelBuilder.Entity<Perform>().HasKey(m => new { m.SimID, m.ActionID});
            modelBuilder.Entity<Travel>().HasKey(m => new { m.SimID, m.WorldID,m.Date });
            modelBuilder.Entity<NeighborhoodDomesticUnits>().HasKey(m => new { m.NeighborhoodID, m.DomesticUnitID });
            modelBuilder.Entity<NeighborhoodPlaces>().HasKey(m => new { m.NeighborhoodID, m.PlaceID });
            modelBuilder.Entity<ProfessionUpgradesSkill>().HasKey(m => new { m.ProfessionID, m.SkillID });
            modelBuilder.Entity<PetLives>().HasKey(m => new { m.PetID, m.DomesticUnitID });
            modelBuilder.Entity<SimLives>().HasKey(m => new { m.SimID, m.DomesticUnitID });
            modelBuilder.Entity<SimSkills>().HasKey(m => new { m.SimID, m.SkillID });
            modelBuilder.Entity<SkillActions>().HasKey(m => new { m.SkillID, m.ActionID });
            
        }
    }
}