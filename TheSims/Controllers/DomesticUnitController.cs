using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSims.Models;

namespace TheSims.Controllers
{
    public class DomesticUnitController : Controller
    {
        private IRepository repository;
        public DomesticUnitController(IRepository repo)
        {
            repository = repo;
        }

        public ActionResult List() => View(repository.DomesticUnits);
    }
}
