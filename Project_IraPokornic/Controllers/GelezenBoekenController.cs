using Microsoft.AspNetCore.Mvc;

namespace Project_IraPokornic.Controllers
{
    public class GelezenBoekenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
