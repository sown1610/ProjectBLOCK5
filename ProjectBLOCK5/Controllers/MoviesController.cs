using Microsoft.AspNetCore.Mvc;
using ProjectBLOCK5.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ProjectBLOCK5.Controllers
{
    public class MoviesController : Controller
    {
        public const string PERSONKEY = "person";
        CenimaDBContext context = new CenimaDBContext();
        Person GetPerson()
        {
            var session = HttpContext.Session;
            string jsonPerson = session.GetString(PERSONKEY);
            if (jsonPerson != null)
            {
                return JsonConvert.DeserializeObject<Person>(jsonPerson);
            }
            return new Person();
        }
        public IActionResult Index()
        {
            ViewBag.Person = GetPerson();
            if (GetPerson().Type == 2 || GetPerson().Type == null)
            {
                return RedirectToAction("Index", "Login");
            }
            //1. List Category
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;

            //2. List Movies
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();

           
            return View(moviesList);
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Person = GetPerson();
            //1. List Category
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            Movie movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            if(movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
            //2. List Movies
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            return View("Index",moviesList);
        }
        public IActionResult AddMovie(string title, string year, string image, string description, int genreid, string button, int MovieId)
        {
            List<Movie> moviesList = new List<Movie>();
            
                // Create a movie and add to database
                Movie movie = new Movie();
                movie.Title = title;
                movie.Year = int.Parse(year);
                movie.Image = image;
                movie.Description = description;
                movie.GenreId = genreid;
                context.Movies.Add(movie);
                context.SaveChanges();

                ViewBag.Person = GetPerson();
                //1. List Category
                List<Genre> genreList = context.Genres.ToList();
                ViewBag.Genres = genreList;

                //2. List Movies
                List<Rate> ratesList = context.Rates.ToList();
                ViewBag.Rates = ratesList;
                moviesList = context.Movies.ToList();
            
            
            return View("Index", moviesList);
        }
        
        public IActionResult Edit(int id)
        {
            ViewBag.Person = GetPerson();
            //1. List Category
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            Movie movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            ViewBag.movie = movie;
            //2. List Movies
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            return View("Index", moviesList);
        }


        public IActionResult Edit1(int id,string title, string year, string image, string description, int genreid)
        {
            ViewBag.Person = GetPerson();
            //1. List Category
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            Movie movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            movie.Title = title;
            movie.Year = int.Parse(year);
            movie.Image = image;
            movie.Description = description;
            movie.GenreId = genreid;
            context.SaveChanges();
            ViewBag.movie = movie;
            //2. List Movies
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            return View("Index", moviesList);
        }

    }
}
