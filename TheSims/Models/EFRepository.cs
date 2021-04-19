using System.Collections.Generic;
using System.Linq;
using TheSims.Models.Relations;
namespace TheSims.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;
        
        public EFRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Sim> Sims => context.Sims;
        public IQueryable<DomesticUnit> DomesticUnits => context.DomesticUnits;
        public IQueryable<Action> Actions => context.Actions;
        public IQueryable<Neighborhood> Neighborhoods => context.Neighborhoods;
        public IQueryable<Pet> Pets => context.Pets;
        public IQueryable<Profession> Professions => context.Professions;
        public IQueryable<Place> Places => context.Places;
        public IQueryable<Quest> Quests => context.Quests;
        public IQueryable<Skill> Skills => context.Skills;
        public IQueryable<World> Worlds => context.Worlds;
      
        
        public IQueryable<Exercise> Exercises => context.Exercises;
        public IQueryable<Involve> Involvements => context.Involvements;
        public IQueryable<Perform> Performances => context.Performances;
        public IQueryable<Travel> Travels => context.Travels;
        public IQueryable<NeighborhoodDomesticUnits> NeighborhoodDomesticUnitsTable => context.NeighborhoodDomesticUnitsTable;
        public IQueryable<NeighborhoodPlaces> NeighborhoodPlacesTable => context.NeighborhoodPlacesTable;
        public IQueryable<ProfessionUpgradesSkill> ProfessionUpgradesSkillsTable => context.ProfessionUpgradesSkillsTable;
        public IQueryable<PetLives> PetLivesTable => context.PetLivesTable;
        public IQueryable<SimLives> SimLivesTable => context.SimLivesTable;
        public IQueryable<SimSkills> SimSkillsTable => context.SimSkillsTable;
        public IQueryable<SkillActions> SkillActionsTable => context.SkillActionsTable;


        public void SaveSim(Sim sim)
        {
            if (sim.SimID == 0)
            {
                context.Sims.Add(sim);
            }
            else
            {
                Sim dbEntry = context.Sims
                .FirstOrDefault(s => s.SimID == sim.SimID);
                if (dbEntry != null)
                {
                    dbEntry.Name = sim.Name;
                    dbEntry.LastName = sim.LastName;
                    dbEntry.Money = sim.Money;
                    dbEntry.Gender = sim.Gender;
                    dbEntry.LifeStage = sim.LifeStage;
                }
            }
            context.SaveChanges();
        }
        public Sim DeleteSim(int simID)
        {
            Sim dbEntry = context.Sims
            .FirstOrDefault(s => s.SimID == simID);
            if (dbEntry != null)
            {
                context.Sims.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}