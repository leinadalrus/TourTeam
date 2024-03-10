namespace AstraleApp.Server.Models
{
  public class Ship
  {
    private Commander DivisionCommander
    {
      get; set;
    }

    private List<string> capabilities
    {
      get; set;
    }

    private String training
    {
      get; set;
    }

    private Dictionary<string, int> speed
    {
      get; set;
    }

    private Dictionary<string, int> endurance
    {
      get; set;
    }

    private Dictionary<int, int> dimensions
    {
      get; set;
    }

    private String propulsion
    {
      get; set;
    }

    private List<string> navigation
    {
      get; set;
    }

    private String communications
    {
      get; set;
    }

    private String weapons
    {
      get; set;
    }

    private String accommodation
    {
      get; set;
    }

    private String lifeSavingEquipment
    {
      get; set;
    }
    private String shipsBoat
    {
      get; set;
    }
  }
}
