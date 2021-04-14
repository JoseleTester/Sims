using System.Linq;
namespace TheSims.Models
{
    public interface IRepository
    {
        IQueryable<Sim> Sims { get; }
        IQueryable<DomesticUnit> DomesticUnits { get; }
    }
}