namespace TourTeam.Server.Components
{
  public interface ICombatFacade
  {
    public byte HealthPoints
    {
      get; set;
    }

    public byte DamageAmount
    {
      get; set;
    }
  }
}
