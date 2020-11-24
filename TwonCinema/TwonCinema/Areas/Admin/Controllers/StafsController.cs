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
    public class StafsController : Controller
    {
        private readonly DPContext _context;

        public StafsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Stafs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stafs.ToListAsync());
        }

        // GET: Admin/Stafs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staf = await _context.Stafs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (staf == null)
            {
                return NotFound();
            }

            return View(staf);
        }

        // GET: Admin/Stafs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Stafs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Password,Avatar,Phone,Address,Status")] Staf staf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staf);
        }

        // GET: Admin/Stafs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staf = await _context.Stafs.FindAsync(id);
            if (staf == null)
            {
                return NotFound();
            }
            return View(staf);
        }

        // POST: Admin/Stafs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Password,Avatar,Phone,Address,Status")] Staf staf)
        {
            if (id != staf.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StafExists(staf.ID))
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
            return View(staf);
        }

        // GET: Admin/Stafs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staf = await _context.Stafs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (staf == null)
            {
                return NotFound();
            }

            return View(staf);
        }

        // POST: Admin/Stafs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staf = await _context.Stafs.FindAsync(id);
            _context.Stafs.Remove(staf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StafExists(int id)
        {
            return _context.Stafs.Any(e => e.ID == id);
        }
    }
}
