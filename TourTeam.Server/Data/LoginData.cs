using TourTeam.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace TourTeam.Server.Data
{
    public class LoginData : DbContext
    {
        public LoginData(DbContextOptions<LoginData> options)
            : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
    }
}
