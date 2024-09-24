namespace TourTeam.Server.Models
{
    public class Inventory
    {
        public Int32 Id { get; set; }
        public String Category { get; set; }
        public Dictionary<Int32, Article> Articles { get; set; }

        public Inventory(int id, String category, Dictionary<Int32, Article> articles)
        {
            Id = id;
            Category = category;
            Articles = articles;
        }
    }
}
