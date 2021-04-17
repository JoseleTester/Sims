using System.Linq;
using TheSims.Models.Relations;
namespace TheSims.Models
{
    public interface IRepository
    {
        IQueryable<Sim> Sims { get; }
        IQueryable<DomesticUnit> DomesticUnits { get; }
        IQueryable<Action> Actions { get; }
        IQueryable<Neighborhood> Neighborhoods { get; }
        IQueryable<Pet> Pets { get; }
        IQueryable<Profession> Professions { get; }
        IQueryable<Place> Places { get; }
        IQueryable<Quest> Quests { get; }
        IQueryable<Skill> Skills { get; }
        IQueryable<World> Worlds { get; }
        

        IQueryable<Exercise> Exercises { get; }
        IQueryable<Involve> Involvements { get; }
        IQueryable<Perform> Performances { get; }
        IQueryable<Travel> Travels { get; }
        IQueryable<NeighborhoodDomesticUnits> NeighborhoodDomesticUnitsTable { get; }
        IQueryable<NeighborhoodPlaces> NeighborhoodPlacesTable { get; }
        IQueryable<ProfessionUpgradesSkill> ProfessionUpgradesSkillsTable { get; }
        IQueryable<PetLives> PetLivesTable { get; }
        IQueryable<SimLives> SimLivesTable { get; }
        IQueryable<SimSkills> SimSkillsTable { get; }
        IQueryable<SkillActions> SkillActionsTable { get; }


       
        void SaveSims(Sim sim);
    //    void SaveDomesticUnits(DomesticUnit domesticUnit);
    //    void SaveActions(Action action);
    //    void SaveNeighborhoods(Neighborhood neighborhood);
    //    void SavePets(Pet pet);
    //    void SaveProfessions(Profession profession);
    //    void SavePlaces(Place place);
    //    void SaveQuests(Quest quest);
    //    void SaveSkills(Skill skill);
    //    void SaveWorlds(World world);

    }
}