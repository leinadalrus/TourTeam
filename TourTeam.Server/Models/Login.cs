using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;

namespace TourTeam.Server.Models
{
    public class Login
    {
        public Customer Customer { get; set; }
        public String Passphrase { get; set; }
    }
}
