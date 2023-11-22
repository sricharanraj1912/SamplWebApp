using Microsoft.AspNetCore.Mvc;

namespace SamplWebApp.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("hello, im a web func");
        }

        [HttpGet("/simplegreet/{pname}")]
        public string SimpleGreet(string pname) {
            return $"welcome to myc,{pname}";
        }

        [HttpGet("/GetNames")] 
        public List<String> GetNames()
        {
            var Names= new List<String>() { "sri","sriii","sriiiiii"};
            return Names;
        }

        [HttpGet("/add/{pName}/{pMarks}/{isPassed?}")]
        public string AddData(string pName, int pMarks,bool isPassed=true)
        {
            return $"{pName} has got {pMarks} and status is {isPassed}";
        }

        [HttpGet("/main")]
        public IActionResult GEtIndexPage()
        {
            ViewBag.ReturnValue = "data passed from controller to view";
            return View("MainPage");
        }
    }
}
