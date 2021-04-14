using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace TheSims.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Sims.Any())
            {
                context.Sims.AddRange(
                new Sim
                {
                    Name = "Simone",
                    LastName = "de Beauvoir",
                    Money = 20000,
                    Gender = 0

                },

                new Sim
                {
                    Name = "Qua",
                    LastName = "Simodo",
                    Money = 300,
                    Gender = 1
                },

                new Sim
                {
                    Name = "Roberlandy",
                    LastName = "Simón",
                    Money = 15.577,
                    Gender = 1
                }

                );
                context.SaveChanges();
            }
            
            if (!context.DomesticUnits.Any())
            {
                context.DomesticUnits.AddRange(
                new DomesticUnit
                {
                    RoomNumber = 4,
                    BathroomNumber = 3,
                    Description = "Very nice place"
                    
                },

                new DomesticUnit
                {
                    RoomNumber = 1,
                    BathroomNumber = 1,
                    Description = "Ugly little house, a pretty big tree at the garden and a couple of ghosts roaming around"

                },
                new DomesticUnit
                {
                    RoomNumber = 2,
                    BathroomNumber = 1,
                    Description = "Perfect to share with a roommate"

                },
                new DomesticUnit
                {
                    RoomNumber = 0,
                    BathroomNumber = 8,
                    Description = "Plenty of bathtubs to sleep in"

                }
                );
                context.SaveChanges();
            }
        }
    }
}