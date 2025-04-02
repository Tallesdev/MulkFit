using Microsoft.AspNetCore.Mvc;

namespace MulkFit.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
