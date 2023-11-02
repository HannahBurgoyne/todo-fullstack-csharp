using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using todo_fullstack_c_.Models;

namespace todo_fullstack_c_.Controllers;

// This controller is responsible for handling requests on the Homepage 
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
  // GET/ Index: method which returns a view result. Index handles the root of the website "/"
    public IActionResult Index()
    {
      // return the View to the browser 
        return View();
    }
  // GET/ Privacy: method which returns a view result. Handles requests to the /privacy page 
    public IActionResult Privacy()
    {
        return View();
    }

  // specifies caching behaviour for errors 
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    // if there is an error, GET/ Error view and information about the error 
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
