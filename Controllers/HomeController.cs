using Microsoft.AspNetCore.Mvc;

namespace SnippetStyler.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
