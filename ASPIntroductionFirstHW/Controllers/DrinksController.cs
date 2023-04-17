using Microsoft.AspNetCore.Mvc;

namespace ASPIntroductionFirstHW.Controllers
{
    public class DrinksController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
