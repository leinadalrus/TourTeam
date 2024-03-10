namespace AstraleApp.Server.Models
{
  public class Staff
  {
    private readonly List<Character> characters;
    private readonly Ship ship;

    public Staff(List<Character> characters, Ship ship)
    {
      this.characters = characters;
      this.ship = ship;
    }

    public List<Character> GetCharacters()
    {
      return this.characters;
    }

    public Ship GetShip()
    {
      return this.ship;
    }
  }
}
