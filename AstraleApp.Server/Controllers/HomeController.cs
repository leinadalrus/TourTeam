using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class HomeController : ControllerBase
  {
    HomeController() { }

    [HttpGet(Name = "GetIndex")]
    public string GetIndex()
    {
      return "index";
    }
  }
}
