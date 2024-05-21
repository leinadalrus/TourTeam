using TourTeam.Server.Components;

namespace TourTeam.Server.Models
{
  public class Login : ILogin
  {
    private String _username;
    private String _password;

    public void Password(string password)
    {
      _password = password;
    }

    public string Password()
    {
      return _password;
    }

    public void Username(string username)
    {
      _username = username;
    }

    public string Username()
    {
      return _username;
    }
  }
}
