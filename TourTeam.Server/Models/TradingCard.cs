using TourTeam.Server.Components;

namespace TourTeam.Server.Models
{
  public class TradingCard
  {
    public String Title
    {
      get; set;
    }

    public String Description
    {
      get; set;
    }

    public String? Flavour
    {
      get; set;
    }

    public ICombatFacade CombatStats
    {
      get; set;
    }

    public EFiveStars FiveStars
    {
      get; set;
    }

    public DateOnly PublishDate
    {
      get; set;
    }
  }
}
