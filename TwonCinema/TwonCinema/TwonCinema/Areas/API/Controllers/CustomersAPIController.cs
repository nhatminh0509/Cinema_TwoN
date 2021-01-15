using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TwonCinema.Areas.Admin.Controllers;
using TwonCinema.Areas.Admin.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwonCinema.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public CustomersAPIController(DPContext context)
        {
            _context = context;
        }

        public string GetCustomerLogin()
        {
            var customer = Middleware.CustomerLogin(HttpContext);
            return JsonConvert.SerializeObject(customer);
        }

        [HttpGet]
        public string ChangeStatus(int id)
        {
            var customer = _context.Customers.FirstOrDefault(m => m.ID == id);
            if (customer.Status == 1)
                customer.Status = 0;
            else
                customer.Status = 1;
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(customer);
        }
    }
}
