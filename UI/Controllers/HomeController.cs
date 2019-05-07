using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger) => Logger = logger;

        public ILogger<HomeController> Logger { get; }

        public IActionResult Index()
        {
            try
            {
                var divider = 0;
                var result = 5 / divider;
            }
            catch (System.Exception ex)
            {
                Logger.LogCritical(ex, ex.Message);
            }

            return Json(new { message = "helloo !" });
        }
    }
}