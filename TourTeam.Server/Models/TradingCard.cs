using TourTeam.Server.Components;

namespace TourTeam.Server.Models
{
  public class TradingCard : ICardPlatform
  {
    private string _title;
    private string _description;
    private string _flavour;

    public string Title
    {
      get => _title;
      set => _title = value;
    }

    public string Description
    {
      get => _description;
      set => _description = value;
    }

    public string? Flavour
    {
      get;
      set;
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
