using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Movie_ShowController : Controller
    {
        private readonly DPContext _context;

        public Movie_ShowController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Movie_Show
        public async Task<IActionResult> ListInRoom(int id)
        {
            if (id.ToString() == null)
            {
                return NotFound();
            }
            var room = _context.Rooms.Where(r => r.ID.Equals(id)).First();
            ViewBag.Room = room;
            var dPContext = _context.Movie_Shows.Include(m => m.Movie).Include(m => m.Room).Where(m => m.Room_ID.Equals(id)).OrderBy(m => m.Start_Show);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Movie_Show/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows
                .Include(m => m.Movie)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie_Show == null)
            {
                return NotFound();
            }

            return View(movie_Show);
        }

        public IActionResult Index(int idCinema, DateTime? date)
        {
            if (idCinema == 0)
            {
                return NotFound();
            }
            if (date == null)
            {
                date = DateTime.Now;
            }

            var listShow = _context.Movie_Shows.Include(m => m.Movie).Include(m => m.Room).Include(m => m.Room.Cinema).Where(m => m.Room.Cinema_ID.Equals(idCinema)).Where(m => m.Start_Show.Year.Equals(date.Value.Year)).Where(m => m.Start_Show.Month.Equals(date.Value.Month)).Where(m => m.Start_Show.Day.Equals(date.Value.Day)).ToArray();
            var listRoom = _context.Rooms.Where(r => r.Cinema_ID.Equals(idCinema)).ToArray();
            var cinema = _context.Cinemas.Where(c => c.ID.Equals(idCinema)).First();
            ViewBag.listMovie = _context.Movies.ToList();
            ViewBag.listShow = listShow;
            ViewBag.listRoom = listRoom;
            ViewBag.Cinema = cinema;
            ViewBag.Date = date.Value;

            return View();
        }

        // POST: Admin/Movie_Show/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Start_Show,Status,Room_ID,Movie_ID")] Movie_Show movie_Show)
        {
            var room = _context.Rooms.Where(m => m.ID.Equals(movie_Show.Room_ID)).First();
            if (ModelState.IsValid)
            {
                var listShowInRoom = _context.Movie_Shows.Where(s => s.Room_ID.Equals(movie_Show.Room_ID)).Where(s => s.Start_Show.Date.Equals(movie_Show.Start_Show.Date)).ToList();
                var movie = _context.Movies.Where(s => s.ID.Equals(movie_Show.Movie_ID)).First();
                int total_m = ConvertToMinute(movie_Show.Start_Show);
                int col = total_m / 10;
                int cell = movie.Running_Time / 10;
                if (movie.Running_Time % 10 > 0)
                {
                    cell = cell + 1;
                }
                if (col > (132 - cell + 1))
                {
                    //ViewBag.ERROR = "Không Đủ Khoảng Trống Để Thêm Ghế " + seat_lv.Name;
                    return Redirect("/Admin/Movie_Show?idCinema=" + room.Cinema_ID + "&date=" + movie_Show.Start_Show.Date);
                }
                foreach (var item in listShowInRoom)
                {
                    col = total_m / 10;
                    for (int i = 1; i <= cell; i++)
                    {
                        if (col == (ConvertToMinute(item.Start_Show) / 10))
                        {
                            //ViewBag.ERROR = "Không Đủ Khoảng Trống Để Thêm Ghế " + seat_lv.Name;
                            return Redirect("/Admin/Movie_Show?idCinema=" + room.Cinema_ID + "&date=" + movie_Show.Start_Show.Date);
                        }
                        col++;
                    }
                }
                _context.Add(movie_Show);
                await _context.SaveChangesAsync();
            }
            return Redirect("/Admin/Movie_Show?idCinema=" + room.Cinema_ID + "&date=" + movie_Show.Start_Show.Date);
        }

        // GET: Admin/Movie_Show/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows.FindAsync(id);
            if (movie_Show == null)
            {
                return NotFound();
            }
            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors", movie_Show.Movie_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", movie_Show.Room_ID);
            return View(movie_Show);
        }

        // POST: Admin/Movie_Show/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Start_Show,Status,Room_ID,Movie_ID")] Movie_Show movie_Show)
        {
            if (id != movie_Show.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie_Show);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Movie_ShowExists(movie_Show.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors", movie_Show.Movie_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", movie_Show.Room_ID);
            return View(movie_Show);
        }

        // GET: Admin/Movie_Show/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows
                .Include(m => m.Movie)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie_Show == null)
            {
                return NotFound();
            }

            return View(movie_Show);
        }

        // POST: Admin/Movie_Show/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie_Show = await _context.Movie_Shows.FindAsync(id);
            _context.Movie_Shows.Remove(movie_Show);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Movie_ShowExists(int id)
        {
            return _context.Movie_Shows.Any(e => e.ID == id);
        }

        int ConvertToMinute(DateTime time)
        {
            int h = time.Hour;
            int m = time.Minute;
            int total_m = h * 60 + m;
            return total_m;
        }
    }
}
