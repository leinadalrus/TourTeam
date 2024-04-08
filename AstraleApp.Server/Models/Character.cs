using System.Runtime.InteropServices;

namespace AstraleApp.Server.Models
{
  public class Character
  {
    private readonly string _nickname;
    private readonly Trait _traits;

    public Character(string newNickname, Trait traitInstance)
    {
      _nickname = newNickname;
      _traits = traitInstance;
    }

    public int ID { get; set; }
    public String FamilyName { get; set; }
    public String GivenName { get; set; }
    public String Nickname { get { return _nickname; } }
    // -> Username : String
    public Trait Traits { get { return _traits; } }
  }
}
