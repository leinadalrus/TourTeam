namespace TourTeam.Server.Components
{
  public interface ILogin
  {
    void Username(string username);
    string Username();

    void Password(string password);
    string Password();
  }
}
