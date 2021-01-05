using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwonCinema.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EquipmentsAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public EquipmentsAPIController(DPContext context)
        {
            _context = context;
        }
        struct Equiment_Custom
        {
            public int ID;
            public string Name;
            public int Row_ID;
            public int Col_ID;
            public int Room_ID;
            public int Count_Cell;
            public int Level_Equipment;
        }
        public string Create(string Name,int Row_ID,int Col_ID,int Room_ID,int Equipment_Level_ID)
        {
            var Equiment_LV = _context.Category_Equipment.Find(Equipment_Level_ID);
            Equipment equipment = new Equipment();
            equipment.Name = Name;
            equipment.Row_ID = Row_ID;
            equipment.Col_ID = Col_ID;
            equipment.Status = 1;
            equipment.Room_ID = Room_ID;
            equipment.Equipment_Level_ID = Equipment_Level_ID;
            _context.Add(equipment);
            _context.SaveChanges();
            Equiment_Custom equiment_Custom = new Equiment_Custom();
            equiment_Custom.ID = equipment.ID;
            equiment_Custom.Name = equipment.Name;
            equiment_Custom.Row_ID = equipment.Row_ID;
            equiment_Custom.Col_ID = equipment.Col_ID;
            equiment_Custom.Room_ID = equipment.Room_ID;
            equiment_Custom.Count_Cell = Equiment_LV.Count_Cell;
            equiment_Custom.Level_Equipment = Equiment_LV.Level;
            return JsonConvert.SerializeObject(equiment_Custom);
        }

        public string ListInRow(int id,int row)
        {
            var equipment = _context.Equipments.Where(e => e.Room_ID.Equals(id)).Where(e => e.Row_ID.Equals(row)).ToList();
            return JsonConvert.SerializeObject(equipment);
        }


    }
}
