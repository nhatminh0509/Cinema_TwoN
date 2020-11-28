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
    public class Movie_ShowAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public Movie_ShowAPIController(DPContext context)
        {
            _context = context;
        }

        struct movieShow
        {
            public int id;
            public int Room_ID;
            public int Movie_ID;
            public int h_start;
            public int m_start;
            public int runningTime;
            public string movieName;
        }

        public string Create(DateTime Start_Show,int Room_ID,int Status,int Movie_ID)
        {
            Movie movie = _context.Movies.Find(Movie_ID);
            Movie_Show movie_Show = new Movie_Show();
            movie_Show.Start_Show = Start_Show;
            movie_Show.Room_ID = Room_ID;
            movie_Show.Status = Status;
            movie_Show.Movie_ID = Movie_ID;
            _context.Add(movie_Show);
            _context.SaveChanges();

            movieShow movieShow = new movieShow();
            movieShow.id = movie_Show.ID;
            movieShow.Room_ID = movie_Show.Room_ID;
            movieShow.Movie_ID = movie_Show.Movie_ID;
            movieShow.h_start = movie_Show.Start_Show.Hour;
            movieShow.m_start = movie_Show.Start_Show.Minute;
            movieShow.runningTime = movie_Show.Movie.Running_Time;
            movieShow.movieName = movie_Show.Movie.Name;
            return JsonConvert.SerializeObject(movieShow);
        }
        public string ListInRoom(int id,DateTime date)
        {
            var dPContext = _context.Movie_Shows.Include(m => m.Movie).Where(m => m.Room_ID.Equals(id)).Where(m=>m.Start_Show.Date.Equals(date.Date));
            List<movieShow> listMovieShow = new List<movieShow>();
            foreach(var item in dPContext.ToList())
            {
                movieShow movieShow = new movieShow();
                movieShow.id = item.ID;
                movieShow.Room_ID = item.Room_ID;
                movieShow.Movie_ID = item.Movie_ID;
                movieShow.h_start = item.Start_Show.Hour;
                movieShow.m_start = item.Start_Show.Minute;
                movieShow.runningTime = item.Movie.Running_Time;
                movieShow.movieName = item.Movie.Name;
                listMovieShow.Add(movieShow);
            }
            return JsonConvert.SerializeObject(listMovieShow);
        }
    }
}
