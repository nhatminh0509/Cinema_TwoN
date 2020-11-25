using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        {

        }
        public DbSet<Staf> Stafs { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Category_Equipment> Category_Equipment { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Movie_Show> Movie_Shows { get; set; }

    }
}
