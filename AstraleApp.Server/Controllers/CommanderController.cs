using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class CommanderController : Controller
  {
    public CommanderController() { }

    [HttpGet(Name = "GetCommander")]
    public string GetCommander()
    {
      return "commander";
    }
  }
}