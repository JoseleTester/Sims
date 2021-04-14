using Microsoft.AspNetCore.Mvc;
using TheSims.Models;
namespace TheSims.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repository;
        public AdminController(IRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Sims);
    }
}