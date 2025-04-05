using Microsoft.AspNetCore.Mvc;

namespace CallManager.Api.Controllers
{
    public class ChamadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
