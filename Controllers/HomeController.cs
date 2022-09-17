using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CaoVanUyBTH.Models;

namespace CaoVanUyBTH.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
[HttpGet]
    public IActionResult Index()
    {
        List<Student> stdList = new List<Student>()
     {
         new Student {StudentID = 1, StudentName = "Nguyen Van A", StudentAge = 18},
         new Student {StudentID = 2, StudentName = "Nguyen Van B", StudentAge = 18},
         new Student {StudentID = 3, StudentName = "Nguyen Van C", StudentAge = 18},
         new Student {StudentID = 4, StudentName = "Nguyen Van D", StudentAge = 18},
         new Student {StudentID = 5, StudentName = "Nguyen Van E", StudentAge = 18},
     };
     ViewData["Students"] = stdList;
       return View();
        
    }
[HttpPost]
    public IActionResult Index(string FullName, string Email)
    {
        ViewBag.name="Hello " + FullName +'-' + Email;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
