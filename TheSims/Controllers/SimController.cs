using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSims.Models;
using TheSims.Models.ViewModels;

namespace TheSims.Controllers
{
    public class SimController : Controller
    {
        private IRepository repository;
        public SimController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult Profile(int id) => View(
            repository.Sims
            .FirstOrDefault(s => s.SimID == id));        

        public ViewResult FilterForm()
        {
            var professions = repository.Professions;
            SimSearchFilterForm form = new SimSearchFilterForm
            {
                Professions = professions
            };
            return View(form);
        }

        public ActionResult List(SimSearchFilterForm form) =>
            View(repository.Sims
                .Where(s =>
                (form.Sim.Name != null && form.Sim.Name == s.Name) || (form.Sim.Name == null && s.Name != null))
                .Where(s =>
                (form.Sim.LastName != null && form.Sim.LastName == s.LastName) || (form.Sim.LastName == null && s.LastName != null))
                );

        //ADMIN
        public ViewResult Index() => View(repository.Sims);
        public ViewResult Edit(int simID) =>
           View(repository.Sims
               .FirstOrDefault(s => s.SimID == simID));

        [HttpPost]
        public IActionResult Edit(Sim sim)
        {

            if (ModelState.IsValid)
            {
                repository.SaveSim(sim);
                TempData["message"] = $"{sim.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // if enters here there is something wrong with the data values
                return View(sim);
            }
        }
        public ViewResult Create() => View("Edit", new Sim());

        [HttpPost]
        public IActionResult Delete(int simID)
        {
            Sim deletedSim = repository.DeleteSim(simID);
            if (deletedSim != null)
            {
                TempData["message"] = $"{deletedSim.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
