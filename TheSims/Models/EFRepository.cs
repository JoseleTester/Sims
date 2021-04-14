using System.Collections.Generic;
using System.Linq;
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
    }
}