
using IndVisaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IndVisaWeb.Controllers
{
    public class VisaController : Controller
    {
        private readonly IndVisaDbContext _context;

        public VisaController(IndVisaDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View("~/Views/Visa/Index.cshtml");
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Visa vis)
        {
            if (ModelState.IsValid)
            {
                _context.Visas.Add(vis);
                _context.SaveChanges();
            }
            return View(vis);
        }
    }
}
