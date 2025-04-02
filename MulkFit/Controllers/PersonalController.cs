using Microsoft.AspNetCore.Mvc;

namespace MulkFit.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
