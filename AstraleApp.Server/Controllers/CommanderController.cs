using AstraleApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class CommanderController : Controller
  {
    private readonly Commander _commander;

    public CommanderController(Commander commander)
    {
      this._commander = commander;
    }

    [HttpGet(Name = "GetCommander")]
    public string GetCommander()
    {
      // get "~/api/commander" routing configured resource
      return "commander";
    }

    [HttpPut(Name = "UpdateCommander")]
    public void UpdateCommander()
    {
    }

    [HttpPost(Name = "EditCommander")]
    public void EditCommander(Commander commander)
    {
      this._commander.Company = commander.Company;
      this._commander.Division = commander.Division;
      this._commander.LastName = commander.LastName;
      this._commander.FirstName = commander.FirstName;
    }

    [HttpDelete]
    public void DestroyCommander()
    {
    }
  }
}