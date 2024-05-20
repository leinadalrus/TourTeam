using TourTeam.Server.Components;

namespace TourTeam.Server.Models
{
  public class TradingCard : ICardPlatform
  {
    public string Title
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }

    public string Description
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }

    public string? Flavour
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
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
