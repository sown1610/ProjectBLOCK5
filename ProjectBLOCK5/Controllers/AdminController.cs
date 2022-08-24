using Microsoft.AspNetCore.Mvc;
using ProjectBLOCK5.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ProjectBLOCK5.Controllers
{
    public class AdminController : Controller
    {
        public const string person = "person";
        CenimaDBContext context = new CenimaDBContext();
        Person GetPerson()
        {
            var session = HttpContext.Session;
            string Person = session.GetString(person);
            if (Person != null)
            {
                return JsonConvert.DeserializeObject<Person>(Person);
            }
            return new Person();
        }

        public IActionResult Index()
        {
            ViewBag.Person = GetPerson();
            if(GetPerson().Type == 2 || GetPerson().Type == null)
            {
                return RedirectToAction("Index", "Login");
            }
            List<Person> persons = context.Persons.ToList();

            List<Movie> movies = context.Movies.ToList();
            ViewBag.TotalMovie = movies.Count;

            List<Rate> rates = context.Rates.ToList();
            ViewBag.TotalComment = rates.Count;

            List<Person> pers = context.Persons.Where(p => p.IsActive == true).ToList();
            ViewBag.TotalAccountActive = pers.Count;

            List<Person> pers2 = context.Persons.Where(p => p.IsActive == false).ToList();
            ViewBag.TotalAccountDeactive = pers2.Count;

            


            return View();
        }
  
    }
}
