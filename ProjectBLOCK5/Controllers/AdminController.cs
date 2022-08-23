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
            if(GetPerson().Type == 2 || GetPerson().Type == null)
            {
                return RedirectToAction("Index", "Login");
            }
            List<Person> persons = context.Persons.ToList();

            //Total person
            List<Movie> movies = context.Movies.ToList();
            ViewBag.TotalMovie = movies.Count;

            //Total Comment
            List<Rate> rates = context.Rates.ToList();
            ViewBag.TotalComment = rates.Count;

            //Total Account Active
            List<Person> pers = context.Persons.Where(p => p.IsActive == true).ToList();
            ViewBag.TotalAccountActive = pers.Count;

            //Total Acount Deactive
            List<Person> pers2 = context.Persons.Where(p => p.IsActive == false).ToList();
            ViewBag.TotalAccountDeactive = pers2.Count;

            


            return View();
        }
  
    }
}
