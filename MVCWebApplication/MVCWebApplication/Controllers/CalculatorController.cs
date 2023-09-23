using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View();
        }

       public int Add(int x, int y)
        {
            return x+y;
        }
    }
}
