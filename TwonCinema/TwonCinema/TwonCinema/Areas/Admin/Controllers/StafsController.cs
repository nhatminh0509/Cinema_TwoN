using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            Middleware.CheckStafLogin(HttpContext);
            return View(await _context.Stafs.ToListAsync());
        }

        // GET: Admin/Stafs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
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
            Middleware.CheckStafLogin(HttpContext);
            return View();
        }

        // POST: Admin/Stafs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Password,Avatar,Phone,Address,Status")] Staf staf, IFormFile ful)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (ModelState.IsValid)
            {
                staf.Password = StringProcessing.CreateMD5(staf.Password);
                _context.Add(staf);
                await _context.SaveChangesAsync();
                var tenImg = staf.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Staf", tenImg);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);

                }
                staf.Avatar = tenImg;
                _context.Update(staf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staf);
        }

        // GET: Admin/Stafs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Password,Avatar,Phone,Address,Status")] Staf staf,IFormFile ful)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id != staf.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var tenImg = staf.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Staf", staf.Avatar);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Staf", tenImg);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        staf.Avatar = tenImg;
                    }
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
            Middleware.CheckStafLogin(HttpContext);
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
            Middleware.CheckStafLogin(HttpContext);
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
