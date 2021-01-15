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
    public class Category_EquipmentController : Controller
    {
        private readonly DPContext _context;

        public Category_EquipmentController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Category_Equipment
        public async Task<IActionResult> Index()
        {
            Middleware.CheckStafLogin(HttpContext);
            return View(await _context.Category_Equipment.ToListAsync());
        }

        // GET: Admin/Category_Equipment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var category_Equipment = await _context.Category_Equipment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (category_Equipment == null)
            {
                return NotFound();
            }

            return View(category_Equipment);
        }

        // GET: Admin/Category_Equipment/Create
        public IActionResult Create()
        {
            Middleware.CheckStafLogin(HttpContext);
            return View();
        }

        // POST: Admin/Category_Equipment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Level,Status")] Category_Equipment Category_Equipment, IFormFile ful, IFormFile ful_selected, IFormFile ful_checked)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (ModelState.IsValid)
            {
                _context.Add(Category_Equipment);
                await _context.SaveChangesAsync();
                var tenImg = Category_Equipment.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImg);
                var tenImgSelected = Category_Equipment.ID + "_selected." + ful_selected.FileName.Split(".")[ful_selected.FileName.Split(".").Length - 1];
                var pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImgSelected);
                var tenImgChecked = Category_Equipment.ID + "_checked." + ful_checked.FileName.Split(".")[ful_checked.FileName.Split(".").Length - 1];
                var pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImgChecked);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);

                }
                using (var stream = new FileStream(pathSelected, FileMode.Create))
                {
                    await ful_selected.CopyToAsync(stream);

                }
                using (var stream = new FileStream(pathChecked, FileMode.Create))
                {
                    await ful_checked.CopyToAsync(stream);

                }
                Category_Equipment.Image = tenImg;
                Category_Equipment.Image_Checked = tenImgChecked;
                Category_Equipment.Image_Selected = tenImgSelected;
                _context.Update(Category_Equipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Category_Equipment);
        }

        // GET: Admin/Category_Equipment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var category_Equipment = await _context.Category_Equipment.FindAsync(id);
            if (category_Equipment == null)
            {
                return NotFound();
            }
            return View(category_Equipment);
        }

        // POST: Admin/Category_Equipment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Level,Status")] Category_Equipment Category_Equipment, IFormFile ful, IFormFile ful_selected, IFormFile ful_checked)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id != Category_Equipment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var tenImg = Category_Equipment.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", Category_Equipment.Image);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImg);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        Category_Equipment.Image = tenImg;
                    }
                    if (ful_selected != null)
                    {
                        var tenImgSelected = Category_Equipment.ID + "_selected." + ful_selected.FileName.Split(".")[ful_selected.FileName.Split(".").Length - 1];
                        var pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", Category_Equipment.Image_Selected);
                        System.IO.File.Delete(pathSelected);
                        pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImgSelected);
                        using (var stream = new FileStream(pathSelected, FileMode.Create))
                        {
                            await ful_selected.CopyToAsync(stream);
                        }
                        Category_Equipment.Image_Selected = tenImgSelected;
                    }
                    if (ful_checked != null)
                    {
                        var tenImgChecked = Category_Equipment.ID + "_checked." + ful_checked.FileName.Split(".")[ful_checked.FileName.Split(".").Length - 1];
                        var pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", Category_Equipment.Image_Checked);
                        System.IO.File.Delete(pathChecked);
                        pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Category_Equipment", tenImgChecked);
                        using (var stream = new FileStream(pathChecked, FileMode.Create))
                        {
                            await ful_checked.CopyToAsync(stream);
                        }
                        Category_Equipment.Image_Checked = tenImgChecked;
                    }
                    _context.Update(Category_Equipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Category_EquipmentExists(Category_Equipment.ID))
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
            return View(Category_Equipment);
        }

        // GET: Admin/Category_Equipment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var category_Equipment = await _context.Category_Equipment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (category_Equipment == null)
            {
                return NotFound();
            }

            return View(category_Equipment);
        }

        // POST: Admin/Category_Equipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Middleware.CheckStafLogin(HttpContext);
            var category_Equipment = await _context.Category_Equipment.FindAsync(id);
            _context.Category_Equipment.Remove(category_Equipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Category_EquipmentExists(int id)
        {
            return _context.Category_Equipment.Any(e => e.ID == id);
        }
    }
}
