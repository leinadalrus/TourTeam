namespace AstraleApp.Server.Models
{
  public class Ship
  {
    public Commander DivisionCommander
    {
      get; set;
    }

    public List<string> capabilities
    {
      get; set;
    }

    public String training
    {
      get; set;
    }

    public Dictionary<string, int> speed
    {
      get; set;
    }

    public Dictionary<string, int> endurance
    {
      get; set;
    }

    public Dictionary<int, int> dimensions
    {
      get; set;
    }

    public String propulsion
    {
      get; set;
    }

    public List<string> navigation
    {
      get; set;
    }

    public String communications
    {
      get; set;
    }

    public String weapons
    {
      get; set;
    }

    public String accommodation
    {
      get; set;
    }

    public String lifeSavingEquipment
    {
      get; set;
    }
    public String shipsBoat
    {
      get; set;
    }
  }
}
