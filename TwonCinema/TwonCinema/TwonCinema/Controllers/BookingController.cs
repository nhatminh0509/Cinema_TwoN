using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

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
            var customer = Middleware.CustomerLogin(HttpContext);
            if (customer == null)
            {
                HttpContext.Session.SetString("err", "1");
                return Redirect("/login");
            }
            var show = _context.Movie_Shows.Find(idShow);
            if(show == null)
            {
                return NotFound();
            }
            
            ViewBag.Customer = customer;
            ViewBag.Show = show;
            var room = _context.Rooms.Include(r => r.Cinema).Where(r => r.ID.Equals(show.Room_ID)).First();
            ViewBag.Room = room;
            var movie = _context.Movies.Find(show.Movie_ID);
            ViewBag.Movie = movie;
            var cate = _context.Category_Equipment.ToList();
            ViewBag.listCate = cate;
            var listEquipmentInRoom = _context.Equipments.Include(m=>m.Category_Equipment).Where(m => m.Room_ID.Equals(show.Room_ID)).Where(m=>m.Status.Equals(1)).ToList();
            ViewBag.listEquipments = listEquipmentInRoom;
            var listBooking = _context.Bookings.Include(m => m.listBookingDetail).Where(b => b.Show_ID.Equals(idShow)).ToList();
            ViewBag.listBooking = listBooking;
            return View();
        }

        [HttpPost]
        public IActionResult Create(string show,string customer,string ghe)
        {
            if(ghe != null)
            {
                string[] listID = ghe.Split(',');
                Booking booking = new Booking();
                booking.Customer_ID = int.Parse(customer);
                booking.Show_ID = int.Parse(show);
                booking.Total_Price = 0;
                booking.Status = 0;
                _context.Add(booking);
                _context.SaveChanges();
                foreach(var item in listID)
                {
                    BookingDetail bookingDetail = new BookingDetail();
                    bookingDetail.Booking_ID = booking.ID;
                    bookingDetail.Seat_ID = int.Parse(item);
                    _context.Add(bookingDetail);
                    var seat = _context.Equipments.Include(m => m.Category_Equipment).Where(m=>m.ID.Equals(bookingDetail.Seat_ID)).FirstOrDefault();
                    booking.Total_Price += seat.Category_Equipment.Price;
                    _context.SaveChanges();
                }
            }
            return Redirect("/");
        }
    }
}
