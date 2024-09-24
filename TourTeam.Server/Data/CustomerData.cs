using TourTeam.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace TourTeam.Server.Data
{
    public class CustomerData : DbContext
    {
        public CustomerData(DbContextOptions<CustomerData> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
