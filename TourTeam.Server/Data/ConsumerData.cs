using TourTeam.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace TourTeam.Server.Data
{
    public class ConsumerData : DbContext
    {
        public ConsumerData(DbContextOptions<ConsumerData> options)
            : base(options)
        {
        }

        public DbSet<Consumer> Consumers { get; set; }
    }
}
