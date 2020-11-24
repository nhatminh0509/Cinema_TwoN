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
    public class Category_MaterialsController : Controller
    {
        private readonly DPContext _context;

        public Category_MaterialsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Category_Materials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category_Materials.ToListAsync());
        }

        // GET: Admin/Category_Materials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category_Materials = await _context.Category_Materials
                .FirstOrDefaultAsync(m => m.ID == id);
            if (category_Materials == null)
            {
                return NotFound();
            }

            return View(category_Materials);
        }

        // GET: Admin/Category_Materials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category_Materials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Level,Status")] Category_Materials category_Materials)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category_Materials);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category_Materials);
        }

        // GET: Admin/Category_Materials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category_Materials = await _context.Category_Materials.FindAsync(id);
            if (category_Materials == null)
            {
                return NotFound();
            }
            return View(category_Materials);
        }

        // POST: Admin/Category_Materials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Level,Status")] Category_Materials category_Materials)
        {
            if (id != category_Materials.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category_Materials);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Category_MaterialsExists(category_Materials.ID))
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
            return View(category_Materials);
        }

        // GET: Admin/Category_Materials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category_Materials = await _context.Category_Materials
                .FirstOrDefaultAsync(m => m.ID == id);
            if (category_Materials == null)
            {
                return NotFound();
            }

            return View(category_Materials);
        }

        // POST: Admin/Category_Materials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category_Materials = await _context.Category_Materials.FindAsync(id);
            _context.Category_Materials.Remove(category_Materials);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Category_MaterialsExists(int id)
        {
            return _context.Category_Materials.Any(e => e.ID == id);
        }
    }
}
