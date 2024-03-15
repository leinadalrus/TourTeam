using AstraleApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class ShipController : Controller
  {
    private readonly Ship _ship;

    public ShipController(Ship ship)
    {
      this._ship = ship;
    }

    [HttpGet(Name = "GetShip")]
    public string GetShip()
    {
      return "ship";
    }

    [HttpPut(Name = "UpdateShip")]
    public void UpdateShip()
    {
    }

    [HttpPost(Name = "EditShip")]
    public void EditShip(Ship ship)
    {
      // Staff from CharacterEditor feature-component
      this._ship.training = ship.training;
    }

    [HttpDelete]
    public void DestroyShip()
    {
    }
  }
  }
}