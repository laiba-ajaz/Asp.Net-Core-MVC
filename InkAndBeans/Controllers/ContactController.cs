using Microsoft.AspNetCore.Mvc;

namespace SimpleRazorEngine.Controllers;

public class ContactController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Title = "Contact Page";
        return View();
    }

   
}
