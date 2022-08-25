using Microsoft.AspNetCore.Mvc;
using ProjectBLOCK5.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
namespace ProjectBLOCK5.Controllers
{
    public class CommentController : Controller
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
            List<Genre> genreList = context.Genres.ToList();
            ViewBag.Genres = genreList;
            List<Person> personList = context.Persons.ToList();
            ViewBag.Person = personList;
            List<Rate> ratesList = context.Rates.ToList();
            ViewBag.Rates = ratesList;
            List<Movie> moviesList = context.Movies.ToList();


            return View(ratesList);
        }
        
       

       


        

    }
}
