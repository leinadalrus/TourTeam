using TourTeam.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace TourTeam.Server.Data
{
    public class ArticleData : DbContext
    {
        public ArticleData(DbContextOptions<ArticleData> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
