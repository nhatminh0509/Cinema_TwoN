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
    public class StafsAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public StafsAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var staf = _context.Stafs.FirstOrDefault(m => m.ID == id);
            if (staf.Status == 1)
                staf.Status = 0;
            else
                staf.Status = 1;
            _context.Stafs.Update(staf);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(staf);
        }
    }
}
