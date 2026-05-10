using Microsoft.AspNetCore.Mvc;

namespace SimpleRazorEngine.Controllers;

public class EventsController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Title = "Events Page"; 
        return View();
    }

   
}
