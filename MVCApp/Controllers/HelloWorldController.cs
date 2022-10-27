using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggy = new DogViewModel(){Name="tits", Age=4};
            return View(doggy);
        }

        public IActionResult Create()
        {
            return View();
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }
}
