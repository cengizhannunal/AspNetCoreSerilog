using AspNetCoreSerilog.Logging.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreLogging.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var message = new { FirstName = "Cengizhan", LastName = "Ünal", Message = "Bu bir test mesajıdır." };
            LoggerFactory.DatabaseLogManager().Information("{@message}", message);
            LoggerFactory.FileLogManager().Information("test");
            return View();
        }
    }
}