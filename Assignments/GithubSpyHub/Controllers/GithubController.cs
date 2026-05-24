using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using GitHubSpyHub.Models;

public class GithubController : Controller
{
    private readonly GithubService _githubService;

    public GithubController(GithubService githubService)
    {
        _githubService = githubService;
    }

    [HttpGet]
    public async Task<IActionResult> ProfileDetails(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
            return RedirectToAction("Index", "Home");
        }

        try
        {
            string json = await _githubService.GetGithubProfileAsync(username);


            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            GithubProfile profile = JsonSerializer.Deserialize<GithubProfile>(json, options)!;

            return View("~/Views/Home/ProfileDetails.cshtml", profile);
        }
        catch (Exception)
        {
            ViewBag.ErrorMessage = "Couldn't find the user!";

            return View("~/Views/Home/Index.cshtml");
        }
    }
}