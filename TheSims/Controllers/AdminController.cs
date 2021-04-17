using Microsoft.AspNetCore.Mvc;
using TheSims.Models;
using System.Linq;
namespace TheSims.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repository;
        public AdminController(IRepository repo)
        {
            repository = repo;
        }
        public ViewResult SimsIndex() => View(repository.Sims);

        
        public ViewResult SimsEdit(int simID) =>
            View(repository.Sims
                .FirstOrDefault(p => p.SimID == simID));
        
        [HttpPost]
        public IActionResult SimsEdit(Sim sim)
        {

            if (ModelState.IsValid)
            {
                repository.SaveSims(sim);
                TempData["message"] = $"{sim.Name} has been saved";
                return RedirectToAction("SimsIndex");
            }
            else
            {
                // there is something wrong with the data values
                return View(sim);
            }
        }
    }
}