<<<<<<< Updated upstream
﻿using TourTeam.Server.Components;

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
=======
﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;

namespace TourTeam.Server.Models
{
    public class Login
    {
        public String Passphrase { get; set; }
        public Consumer Consumer { get; set; }
    }
>>>>>>> Stashed changes
}
