using AstraleApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LoginController : Controller
  {
    private readonly Character _character;

    private readonly string[,] _identifiers = new[,]
    {
      {"1", "Doe", "Jon"},
    };

    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger, Character character)
    {
      this._logger = logger;
      this._character = character;
    }

    [HttpGet]
    public string[,] GetIdentifiers()
    {
      return this._identifiers;
    }

    [HttpGet(Name = "GetLogin")]
    public void GetLogin()
    {
      // Fetch form-data: "email" and "password"
    }

    [HttpPut(Name = "UpdateLogin")]
    [AutoValidateAntiforgeryToken]
    public void UpdateLogin()
    {
    }

    [HttpPost(Name = "UpdateLogins")]
    [AutoValidateAntiforgeryToken]
    public void UpdateLogins(Character character)
    {
      // Staff from CharacterEditor feature-component
    }

    [HttpDelete]
    public void DestroyLogin()
    {
    } // destroy login session
  }
}
