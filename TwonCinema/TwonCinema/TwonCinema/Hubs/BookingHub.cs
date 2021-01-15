using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Data;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema.Hubs
{
    public class BookingHub : Hub
    {
        private readonly DPContext _context;

        public BookingHub(DPContext context)
        {
            _context = context;
        }
        public async Task SelectSeat(string customer,string show,int id,string name, int row,int col,int level,int status)
        {
            await Clients.All.SendAsync("ReceiveSeat",customer, show,id,name, row,col,level,status);
        }
    }
}
