using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CornerstoneAssessmentMVC.Models;
using Newtonsoft.Json;

namespace CornerstoneAssessmentMVC.Controllers
{
    public class HomeController : Controller
    {
        //Reads data from json file into a PersonList object. Calls methods to display info from PersonList
        public ActionResult Index()
        {
            List<Person> objPerson = new List<Person>();

            var path = Server.MapPath(@"~/Json/code_test.json");
            using (StreamReader file = new StreamReader(path, true))
            {
                var json = file.ReadToEnd();
                objPerson = JsonConvert.DeserializeObject<List<Person>>(json);
            }

            //Orders all list of people by age
            ViewData["OrderedByAge"] = objPerson.OrderByDescending(o => o.Age).ToList();
            //Gets count of all people
            ViewData["TotalCount"] = objPerson.Count;
            //Gets men that are active with blue eyes in Person List
            ViewData["MenWithBlues"] = objPerson.Where(p => (p.EyeColor == "blue") && (p.Gender == "male") && (p.IsActive) && p.Age > 30).ToList();
            //Orders men that are active with blue eyes by age 
            ViewData["OrderedMenWithBlues"] = objPerson.Where(p => (p.EyeColor == "blue") && (p.Gender == "male") && (p.IsActive) && p.Age > 30).OrderByDescending(o => o.Age).ToList();
            //Gets count of active men with blue eyes
            ViewData["TotalCountMenWithBlues"] = objPerson.Where(p => (p.EyeColor == "blue") && (p.Gender == "male") && (p.IsActive) && p.Age > 30).ToList().Count;
            //Gets count of poeple with less than 3 friends
            ViewData["LessThan3Friends"] = objPerson.Where(p => (p.Friends.Count < 3)).ToList().Count;


            return View(objPerson);
        }


    }
}