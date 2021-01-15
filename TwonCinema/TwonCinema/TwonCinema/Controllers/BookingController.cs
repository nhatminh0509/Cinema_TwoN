using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;

namespace TwonCinema.Controllers
{
    public class BookingController : Controller
    {
        private readonly DPContext _context;

        public BookingController(DPContext context)
        {
            _context = context;
        }
        public IActionResult SelectSeat(int? idShow)
        {
            Middleware.CheckCustomerLogin(HttpContext);
            if (idShow == null)
            {
                return NotFound();
            }
            var show = _context.Movie_Shows.Find(idShow);
            if(show == null)
            {
                return NotFound();
            }
            ViewBag.Show = show;
            var room = _context.Rooms.Include(r => r.Cinema).Where(r => r.ID.Equals(show.Room_ID)).First();
            ViewBag.Room = room;
            var movie = _context.Movies.Find(show.Movie_ID);
            ViewBag.Movie = movie;
            var cate = _context.Category_Equipment.ToList();
            ViewBag.listCate = cate;
            var listEquipmentInRoom = _context.Equipments.Include(m=>m.Category_Equipment).Where(m => m.Room_ID.Equals(show.Room_ID)).ToList();
            ViewBag.listEquipments = listEquipmentInRoom;
            return View();
        }

        [HttpPost]
        public IActionResult Booking(string show,string ghe)
        {
            string[] listID = ghe.Split(',');

            return View();
        }
    }
}
