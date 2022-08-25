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
        public IActionResult Index(string? search)
        {
            ViewBag.Person = GetPerson();
            if (GetPerson().Type == 2 || GetPerson().Type == null)
            {
                return RedirectToAction("Index", "Login");
            }
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;

            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            if (search != null)
            {

                moviesList = context.Movies.Where(m => m.Title.Contains(search.Trim())).ToList();
            }

            return View(moviesList);
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Person = GetPerson();
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            Movie movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            if (movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            return View("Index", moviesList);
        }
        public IActionResult AddMovie(string title, string year, string image, string description, int genreid, string button, int MovieId)
        {
            List<Movie> moviesList = new List<Movie>();

            Movie movie = new Movie();
            movie.Title = title;
            movie.Year = int.Parse(year);
            movie.Image = image;
            movie.Description = description;
            movie.GenreId = genreid;
            context.Movies.Add(movie);
            context.SaveChanges();

            ViewBag.Person = GetPerson();
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            moviesList = context.Movies.ToList();


            return View("Index", moviesList);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Person = GetPerson();
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            Movie movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            ViewBag.movie = movie;
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();
            return View("Index", moviesList);
        }


        public IActionResult Edit1(string title, string year, string image, string description, int genreid, string button, int MovieId)
        {
            List<Movie> moviesList = new List<Movie>();
            if (button.Equals("Edit"))
            {
                ViewBag.Person = GetPerson();
                Movie movieX = context.Movies.Where(m => m.MovieId == MovieId).FirstOrDefault();
                movieX.Title = title;
                movieX.Year = int.Parse(year);
                movieX.Image = image;
                movieX.Description = description;
                movieX.GenreId = genreid;
                context.SaveChanges();

                List<Genre> genreList = context.Genres.ToList();
                ViewBag.Genres = genreList;
                List<Rate> ratesList = context.Rates.ToList();
                ViewBag.Rates = ratesList;
                moviesList = context.Movies.ToList();
            }


            return View("Index", moviesList);
        }

    }
}
