using Microsoft.AspNetCore.Mvc;
using TourTeam.Server.Models;

namespace TourTeam.Server.Controllers
{
  [ApiController]
  [Route("/")]
  public class HomeController : ControllerBase // Model Controller, no View
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IEnumerable<TradingCard> Get()
    {
      return Enumerable.Range(0, 1).Select(card => new TradingCard
      {
        Title = "",
        Description = "",
        Flavour = "",
        CombatStats = { HealthPoints = 1, DamageAmount = 1 },
        FiveStars = Components.EFiveStars.OneStar,
        PublishDate = DateOnly.FromDateTime(DateTime.Now)
      });
    }
  }
}
