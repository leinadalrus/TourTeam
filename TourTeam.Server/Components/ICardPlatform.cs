namespace TourTeam.Server.Components
{
  public interface ICardPlatform
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
  }
}
