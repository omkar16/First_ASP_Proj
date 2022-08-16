using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Info()
        {
            Movie movie = new Movie() { Id = 1, Name = "Dangal", Year = 2018, Rating = 5 };
            return View(movie);
        }
        public IActionResult Search() {
            return View();
        }
        public IActionResult List() {
            List<Movie> movies = GetMovies();
            return View(movies);
        }
        public List<Movie> GetMovies() {
            List<Movie> movies = new List<Movie> {
             new Movie{ Id=1, Name="War", Year=2019, Rating=3 },
             new Movie{ Id=2, Name="Dangal", Year=2016, Rating=4 },
             new Movie{ Id=3, Name="PK", Year=2012, Rating=5 },
             new Movie{ Id=4, Name="Lucy", Year=2015, Rating=5 },
             new Movie{ Id=5, Name="Matrix", Year=2021, Rating=4 },
             new Movie{ Id=6, Name="Martian", Year=2015, Rating=5 },
            };
            return movies;       
        }
        public IActionResult Find(int id) {
            List<Movie> movies = GetMovies();
            Movie data = movies.Where(m => m.Id == id).FirstOrDefault();
            return View("Info",data);
        }
        [HttpGet]
        public IActionResult FindByRating() {
            List<int> ratinglist = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratinglist);
            return View();
        }
        [HttpPost]
        public IActionResult FindByRating(int rating) {
            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Rating == rating);
            ViewBag.MovieList = data;
            List<int> ratinglist = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratinglist);
            return View();
        }
    }
}
