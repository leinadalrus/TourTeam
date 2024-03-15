using AstraleApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ShipController : Controller
  {
    private readonly Ship _ship;

    private readonly string[] _attributes = new[]
    {
      "Commander", "Capabilities", "Training", "Speed", "Endurance",
      "Dimensions", "Propulsion", "Navigation", "Communications",
      "Weapons", "Accomodation", "Equipment", "Boats"
    };

    private readonly ILogger<ShipController> _logger;

    public ShipController(ILogger<ShipController> logger, Ship ship)
    {
      this._logger = logger;
      this._ship = ship;
    }

    [HttpGet]
    public string[] GetAttributes()
    {
      return this._attributes;
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

