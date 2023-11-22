using Microsoft.AspNetCore.Mvc;
using SamplWebApp.Models;
using System.Reflection.Metadata.Ecma335;

namespace SamplWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people")]
        public IActionResult GetPeople()
        {
            //get model class
            var people=PersonOpertaions.GetPeople();
            //display values
            return View("peoplelist",people);
                        
        }
        
        [HttpGet("/search/{pAadhar}")]
        public IActionResult GetPersonDetails(string pAadhar) {
            //call model class method
            var found = PersonOpertaions.Search(pAadhar);
            //return the matching person to view
            return View("Search", found);
        }
        [HttpGet("/people/of/age/{startage}/{endage}")]
        public IActionResult GetPeopleWithAge(int startage, int endage) {
            
            //write new function in PersonOPeration class
           var found= PersonOpertaions.getPeopleAge(startage,endage);

            return View("peopleage", found);
        }
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View("Create",new Person());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm]Person p) 
        {
            //call model method from person operations
            PersonOpertaions.CreateNew(p);
            return View("PeopleList",PersonOpertaions.GetPeople());
        }
        [HttpGet("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar)
        {
        var found = PersonOpertaions.Search(pAadhar);
            return View("Edit",found);
        }
        [HttpPost("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar,[FromForm] Person p) {
            var found = PersonOpertaions.Search(p.Aadhar);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
        return View("PeopleList", PersonOpertaions.GetPeople());
        }
    }
    
}
