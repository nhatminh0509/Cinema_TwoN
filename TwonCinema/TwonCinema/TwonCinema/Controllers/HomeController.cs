using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;

namespace TwonCinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Top4 = _context.Movies.Take(4).ToArray();
            ViewBag.Top4 = Top4;
            var listMovie = _context.Movies.ToList();
            ViewBag.listMovie = listMovie;
            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }
    }
}
