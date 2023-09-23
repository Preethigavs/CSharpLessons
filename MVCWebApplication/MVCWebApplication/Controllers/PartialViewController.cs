using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialViewController
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are good friends";
            return View();
        }
    }
}
