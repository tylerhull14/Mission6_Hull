using Microsoft.AspNetCore.Mvc;
using Mission6_Hull.Models;
using System.Diagnostics;

namespace Mission6_Hull.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger; // Constructor (ILogger of type home controller)

        private readonly CollectionFormContext _context;

        public HomeController(CollectionFormContext temp) // Constructor
        {
            _context = temp;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult collection ()
        {
            return View("collection");
        }

        [HttpPost]
        public IActionResult collection(Form response)
        {
            _context.Forms.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Index");
        }
    }
}
