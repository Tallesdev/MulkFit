using Microsoft.AspNetCore.Mvc;

namespace MulkFit.Controllers
{
    public class ExercicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
