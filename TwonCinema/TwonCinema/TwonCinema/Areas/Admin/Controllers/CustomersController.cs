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
    public class CustomersController : Controller
    {
        private readonly DPContext _context;

        public CustomersController(DPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int status=1)
        {
            Middleware.CheckStafLogin(HttpContext);
            var dPContext = _context.Customers.Where(c=>c.Status==status);
            ViewBag.ListCustomer =await dPContext.ToListAsync();
            return View();
        }

    }
}
