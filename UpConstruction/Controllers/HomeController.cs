using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UpConstruction.DAL;
using UpConstruction.Models;

namespace UpConstruction.Controllers
{
    public class HomeController:Controller
    {
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
