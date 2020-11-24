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
    public class CinemasController : Controller
    {
        private readonly DPContext _context;

        public CinemasController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Cinemas
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Cinemas.Include(c => c.Staf);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Cinemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinemas
                .Include(c => c.Staf)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }

        // GET: Admin/Cinemas/Create
        public IActionResult Create()
        {
            ViewData["Manager_ID"] = new SelectList(_context.Stafs, "ID", "Email");
            return View();
        }

        // POST: Admin/Cinemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Address,Hotline,Status,Manager_ID")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cinema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Manager_ID"] = new SelectList(_context.Stafs, "ID", "Email", cinema.Manager_ID);
            return View(cinema);
        }

        // GET: Admin/Cinemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinemas.FindAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }
            ViewData["Manager_ID"] = new SelectList(_context.Stafs, "ID", "Email", cinema.Manager_ID);
            return View(cinema);
        }

        // POST: Admin/Cinemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Address,Hotline,Status,Manager_ID")] Cinema cinema)
        {
            if (id != cinema.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cinema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemaExists(cinema.ID))
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
            ViewData["Manager_ID"] = new SelectList(_context.Stafs, "ID", "Email", cinema.Manager_ID);
            return View(cinema);
        }

        // GET: Admin/Cinemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinemas
                .Include(c => c.Staf)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }

        // POST: Admin/Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinema = await _context.Cinemas.FindAsync(id);
            _context.Cinemas.Remove(cinema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CinemaExists(int id)
        {
            return _context.Cinemas.Any(e => e.ID == id);
        }
    }
}
