using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Models;
using System.Diagnostics;
using System.Text;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int x, IFormCollection collection)
        {
            StringBuilder data = new StringBuilder(500);
            data.Append("x: ");
            data.Append(x);
            data.Append(" ");
            data.Append("name");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password");
            data.Append(collection["password"]);
            //foreach(var item in collection)
            //{
            //    data.Append(item.Key);
            //    data.Append(":");
            //    data.Append(item.Value);
            //}
            ViewData["x"] = x;
            //TempData["global_x"] = x; //transfer data between one controller to another controller using TempData[ ]
            
            return View("IndexPost"); 
            // TEMP DATA - is global 
            //view data - to local scope
        }
        public ActionResult DoTask(int? id) // id is nullable values
        {
            if(id.HasValue) // when id is not explicilty given then in url just give controller/action/?id=121 else give controller/action/121 
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }

            return View("DoTask");
        }

        //redirect to Action
        public ActionResult Test() // can we call action using another action ? - no we can't so use RedirectToAction()
        {

            //return View();
            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            Book b1 = new Book()
            {
                AuthorName = "Hi Ross"
            };
            ViewData["book"] = b1;
            return View();

        }
        [ResponseCache(Duration =15)] // output cache - for a specific duration in seconds
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Menu()
        {
            String constring = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information, constring);
            _logger.Log(LogLevel.Information, "Testing"); // logger.log() - writes in file //loglevel.infor - enum
            return View();
        }
        public ActionResult Echo(String name, String city)
        {
            String s1 = "user " + name + " from city " + city;
            ViewData.Add("Data1", s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            String s2 = ("hello " + name);
            ViewData.Add("Data1", s2);
            return View("Echo");
        }
    }
}

