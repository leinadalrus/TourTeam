using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class HomeController : Controller
  {
    HomeController() { }

    [HttpGet(Name = "GetIndex")]
    public string GetIndex()
    {
      // get "index.html" template resource
      return "index";
    }
  }
}
