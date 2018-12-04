using Microsoft.AspNetCore.Mvc;
using TaskMaster.Models;

namespace TaskMaster.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
