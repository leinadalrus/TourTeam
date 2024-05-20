using Microsoft.AspNetCore.Mvc;
using TourTeam.Server.Models;

namespace TourTeam.Server.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TradingCardController : ControllerBase
  {
    private readonly TradingCard[] TradingCards = Array.Empty<TradingCard>();

    private readonly ILogger<TradingCardController> _logger;

    public TradingCardController(ILogger<TradingCardController> logger)
    {
      _logger = logger;
    }

    [HttpGet("GetTradingCard")]
    public IEnumerable<TradingCard> Get()
    {
      return TradingCards;
    }
  }
}
