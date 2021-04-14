using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSims.Models;

namespace TheSims.Controllers
{
    public class SimController : Controller
    {
        private IRepository repository;
        public SimController(IRepository repo)
        {
            repository = repo;
        }
        
        [HttpPost]
        public ActionResult Consult(Sim sim)
        {
            return RedirectToAction("List","Sim",sim);
        }
        public ViewResult FilterForm() => View();
        public ActionResult List(Sim sim) =>
            View(repository.Sims.Where(s =>
                (sim.Name != null && sim.Name == s.Name) || (sim.Name == null && s.Name != null)

                ));
        
    }
}
