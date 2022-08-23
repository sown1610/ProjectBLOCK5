using Microsoft.AspNetCore.Mvc;
using ProjectBLOCK5.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ProjectBLOCK5.Controllers
{
    public class GenreController : Controller
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
            List<Genre> listGenre = context.Genres.ToList();
            return View(listGenre);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewBag.Person = GetPerson();

            Genre genre = new Genre(); ;
            genre.Description = name;
            context.Genres.Add(genre);
            context.SaveChanges();
            List<Genre> listGenre = context.Genres.ToList();
            return View(listGenre);
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Person = GetPerson();
            Genre genre =  context.Genres.Where(g => g.GenreId == id).FirstOrDefault();
            if(genre != null)
            {
                context.Genres.Remove(genre);
                context.SaveChanges();
            }
            List<Genre> listGenre = context.Genres.ToList();
            return View("Index", listGenre);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Person = GetPerson();
            if (GetPerson().Type == 2 || GetPerson().Type == null)
            {
                return RedirectToAction("Index", "Login");
            }
            Genre genre = context.Genres.Where(g => g.GenreId == id).FirstOrDefault();

            return View(genre);
        }
        [HttpPost]
        public IActionResult Edit(int id,string name)
        {
            ViewBag.Person = GetPerson();
            Genre genre = context.Genres.Where(g => g.GenreId == id).FirstOrDefault();
            genre.Description = name;
            context.SaveChanges();
            return View(genre);
        }
    }
}
