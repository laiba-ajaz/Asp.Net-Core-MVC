using Microsoft.AspNetCore.Mvc;

namespace SimpleRazorEngine.Controllers;

public class MenuController : Controller
{

    public IActionResult Index()
    {
            ViewBag.Title = "Menu Page";
        return View();
    }

   
}
