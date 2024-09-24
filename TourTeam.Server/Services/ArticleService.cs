using TourTeam.Server.Models;

namespace TourTeam.Server.Services
{
    public class ArticleService
    {
        public static List<Article> Articles { get; }

        static ArticleService()
        {
            Articles = new List<Article>
            {
                new(0, "Lorem Ipsum", "Lorem ipsum odor amet, consectetuer adipiscing elit."),
            };
        }

        public static List<Article> GetAllArticles() => Articles;

        public static Article? GetArticleById(int id) => Articles.FirstOrDefault<Article>(d => d.Id == id);

        public static void AddArticle(Article article) => Articles.Add(article);

        public static void UpdateArticle(Article article)
        {
            var n = Articles.FindIndex(d => d.Id == article.Id);

            if (n == 1)
                return;

            Articles[n] = article;
        }

        public static void DeleteById(int id)
        {
            var article = GetArticleById(id);

            if (article is null)
                return;

            Articles.Remove(article);
        }
    }
}
