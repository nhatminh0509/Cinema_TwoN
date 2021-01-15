using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema.Controllers
{
    public class LoginController : Controller
    {
        private readonly DPContext _context;

        public LoginController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customer = Middleware.CustomerLogin(HttpContext);
            if (customer != null)
            {
                return Redirect("/");
            }
            var err = HttpContext.Session.GetString("err");
            if(err == null)
            {
                err = "";
            }
            ViewBag.err = err;
            HttpContext.Session.SetString("err", "");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        public IActionResult Register()
        {
            var customer = Middleware.CustomerLogin(HttpContext);
            if (customer != null)
            {
                return Redirect("/");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login([Bind("Name,Email,Password,Phone,Total_Spending,Status")] Customer customer)
        {
            var login = _context.Customers.Where(s => (s.Email.Equals(customer.Email) && s.Password.Equals(StringProcessing.CreateMD5(customer.Password))));
            if (login.ToList().Count == 0)
            {
                return View("Index");
            }
            var str = JsonConvert.SerializeObject(login.First());
            HttpContext.Session.SetString("customer", str);
            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Register([Bind("Name,Email,Password,Phone,Total_Spending,Status")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Password = StringProcessing.CreateMD5(customer.Password);
                _context.Add(customer);
                _context.SaveChangesAsync();
                return View("Index");
            }
            return View("Index");
        }
    }
}
