using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
      public ActionResult Start()
        {
            return View();
        }

    }
}
