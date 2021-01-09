using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;

namespace TwonCinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DPContext _context;

        public MoviesController(DPContext context)
        {
            _context = context;
        }
        public IActionResult NowShowing()
        {
            var listMovie = _context.Movies.ToList();
            ViewBag.listMovie = listMovie;
            return View();
        }

        public IActionResult ComingSoon()
        {
            var listMovie = _context.Movies.ToList();
            ViewBag.listMovie = listMovie;
            return View();
        }

        public IActionResult Movie(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewBag.Movie = movie;
            var listMovie = _context.Movies.ToList();
            ViewBag.listMovie = listMovie;

            return View();
        }
    }
}
