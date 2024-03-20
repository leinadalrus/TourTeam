using System.Runtime.InteropServices;

namespace AstraleApp.Server.Models
{
  public class Character
  {
    private readonly int id;
    private readonly string nickname;
    private readonly Trait traits;

    public Character(string newName, Trait traitInstance)
    {
      this.nickname = newName;
      this.traits = traitInstance;
    }

    public Character(int id)
    {
      this.id = id;
    }

    public int GetId()
    {
      return this.id;
    }

    public String GetName()
    {
      return this.nickname;
    }

    public Trait GetTraits()
    {
      return this.traits;
    }
  }
}
