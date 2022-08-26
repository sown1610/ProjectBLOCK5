using Microsoft.AspNetCore.Mvc;
using ProjectBLOCK5.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ProjectBLOCK5.Controllers
{
    public class MemberController : Controller
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
            List<Genre> genres = context.Genres.ToList();
            List<Person> persons = context.Persons.ToList();
            return View(persons);
        }
        public IActionResult SetStatus(int id, bool status)
        {
            Person person = context.Persons.Where(p => p.PersonId == id).FirstOrDefault();
            person.IsActive = status;
            context.SaveChanges();

            ViewBag.Person = GetPerson();
            List<Genre> genres = context.Genres.ToList();
            List<Person> persons = context.Persons.ToList();

            return View("Index",persons);
        }
    }
}
