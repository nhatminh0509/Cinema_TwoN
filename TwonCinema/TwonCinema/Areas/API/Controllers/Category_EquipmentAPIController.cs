using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TwonCinema.Areas.Admin.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwonCinema.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Category_EquipmentAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public Category_EquipmentAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var obj = _context.Category_Equipment.FirstOrDefault(m => m.ID == id);
            if (obj.Status == 1)
                obj.Status = 0;
            else
                obj.Status = 1;
            _context.Category_Equipment.Update(obj);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(obj);
        }
    }
}
