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
    public class EquipmentsController : Controller
    {
        private readonly DPContext _context;

        public EquipmentsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Equipments
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = _context.Rooms.Find(id);
            var listCategory_Equipment = _context.Category_Equipment.ToList();
            var listEquipment = _context.Equipments.Include(e => e.Category_Equipment).Where(e => e.Room_ID.Equals(id)).ToList();
            ViewBag.Room = room;
            ViewBag.listCategory_Equipment = listCategory_Equipment;
            ViewBag.listEquipment = listEquipment;
            return View();
        }

        // GET: Admin/Equipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments
                .Include(e => e.Category_Equipment)
                .Include(e => e.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // GET: Admin/Equipments/Create
        public IActionResult Create()
        {
            ViewData["Equipment_Level_ID"] = new SelectList(_context.Category_Equipment, "ID", "Name");
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name");
            return View();
        }

        // POST: Admin/Equipments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Row_ID,Col_ID,Status,Room_ID,Equipment_Level_ID")] Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipment);
                await _context.SaveChangesAsync();
            }
            return Redirect("/Admin/Equipments/Index/" + equipment.Room_ID);
        }

        // GET: Admin/Equipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }
            ViewData["Equipment_Level_ID"] = new SelectList(_context.Category_Equipment, "ID", "Name", equipment.Equipment_Level_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", equipment.Room_ID);
            return View(equipment);
        }

        // POST: Admin/Equipments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Row_ID,Col_ID,Status,Room_ID,Equipment_Level_ID")] Equipment equipment)
        {
            if (id != equipment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentExists(equipment.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Equipments/Index/" + equipment.Room_ID);
            }
            ViewData["Equipment_Level_ID"] = new SelectList(_context.Category_Equipment, "ID", "Name", equipment.Equipment_Level_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", equipment.Room_ID);
            return View(equipment);
        }

        // GET: Admin/Equipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments
                .Include(e => e.Category_Equipment)
                .Include(e => e.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // POST: Admin/Equipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);
            _context.Equipments.Remove(equipment);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Equipments/Index/" + equipment.Room_ID);
        }

        private bool EquipmentExists(int id)
        {
            return _context.Equipments.Any(e => e.ID == id);
        }
    }
}
