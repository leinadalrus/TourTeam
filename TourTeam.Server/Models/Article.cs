namespace TourTeam.Server.Models
{
    public class Article
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public DateOnly Date { get; set; }

        public Article(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }
    }
}
