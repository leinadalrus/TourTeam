using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class CommanderController : ControllerBase
  {
    public CommanderController() { }

    [HttpGet(Name = "GetCommander")]
    public string GetCommander()
    {
      return "commander";
    }
  }
}