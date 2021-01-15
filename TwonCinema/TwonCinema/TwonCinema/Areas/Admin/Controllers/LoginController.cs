using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DPContext _context;

        public LoginController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var staf = Middleware.StafLogin(HttpContext);
            if (staf != null)
            {
                return Redirect("/Admin");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login ([Bind("Name,Email,Password,Avatar,Phone,Address,Status")] Staf staf)
        {
            var login = _context.Stafs.Where(s => (s.Email.Equals(staf.Email) && s.Password.Equals(StringProcessing.CreateMD5(staf.Password))));
            if(login.ToList().Count == 0)
            {
                return View("Index");
            }
            var str = JsonConvert.SerializeObject(login.First());
            HttpContext.Session.SetString("staf", str);
            return Redirect("/Admin/Home/Index");
        }
    }
}
