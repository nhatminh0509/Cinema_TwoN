﻿using System;
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
    public class MoviesController : Controller
    {
        private readonly DPContext _context;

        public MoviesController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Movies
        public async Task<IActionResult> Index(int status = 1)
        {
            Middleware.CheckStafLogin(HttpContext);
            return View(await _context.Movies.Where(c => c.Status == status).ToListAsync());
        }

        // GET: Admin/Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Admin/Movies/Create
        public IActionResult Create()
        {
            Middleware.CheckStafLogin(HttpContext);
            return View();
        }

        // POST: Admin/Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image_1,Image_2,Trailer,Directors,Cast,Genre,Release_Date,Running_Time,Language,Rated,Desc,Keyword,Slug,Status")] Movie movie, IFormFile ful, IFormFile ful_2)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                if (ful != null)
                {
                   
                    var tenImg = movie.ID + "_1." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", tenImg);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    movie.Image_1 = tenImg;
                }
               
                if(ful_2 != null)
                {
                    var tenImg_2 = movie.ID + "_2." + ful_2.FileName.Split(".")[ful_2.FileName.Split(".").Length - 1];
                    var path_2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", tenImg_2);
                    using (var stream = new FileStream(path_2, FileMode.Create))
                    {
                        await ful_2.CopyToAsync(stream);
                    }
                    movie.Image_2 = tenImg_2;
                }

                _context.Update(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Admin/Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Admin/Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image_1,Image_2,Trailer,Directors,Cast,Genre,Release_Date,Running_Time,Language,Rated,Desc,Keyword,Slug,Status")] Movie movie, IFormFile ful, IFormFile ful_2)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var tenImg = movie.ID + "_1." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", movie.Image_1);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", tenImg);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        movie.Image_1 = tenImg;
                    }
                    if (ful_2 != null)
                    {
                        var tenImg_2 = movie.ID + "_2." + ful_2.FileName.Split(".")[ful_2.FileName.Split(".").Length - 1];
                        var path_2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", movie.Image_2);
                        System.IO.File.Delete(path_2);
                        path_2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Movie", tenImg_2);
                        using (var stream = new FileStream(path_2, FileMode.Create))
                        {
                            await ful_2.CopyToAsync(stream);
                        }
                        movie.Image_2 = tenImg_2;
                    }
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
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
            return View(movie);
        }

        // GET: Admin/Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Middleware.CheckStafLogin(HttpContext);
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Admin/Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Middleware.CheckStafLogin(HttpContext);
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.ID == id);
        }
    }
}
