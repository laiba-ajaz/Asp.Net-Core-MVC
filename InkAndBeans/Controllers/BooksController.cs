using Microsoft.AspNetCore.Mvc;

namespace SimpleRazorEngine.Controllers;

public class BooksController : Controller
{

    public IActionResult Index()
    {
         ViewBag.title = "bookPage";
        return View();
    }

   
}
