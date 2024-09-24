using TourTeam.Server.Data;
using TourTeam.Server.Models;
using TourTeam.Server.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourTeam.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        readonly ArticleData _articleData;

        public ArticlesController(ArticleData articleData)
        {
            _articleData = articleData;
        }

        // GET: api/<ArticlesController>
        [HttpGet]
        public ActionResult<List<Article>> GetAllArticles() => ArticleService.GetAllArticles();

        // GET api/<ArticlesController>/5
        [HttpGet("{id}")]
        public ActionResult<Article> GetArticleById(int id, ActionResult<Article> article) => article;

        // POST api/<ArticlesController>
        [HttpPost]
        public void Post([FromBody] Article article)
        {
            ArticleService.AddArticle(article);
            CreatedAtAction(nameof(GetArticleById), new { id = article.Id }, article);
        }

        // PUT api/<ArticlesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Article article)
        {
            if (id != article.Id)
            {
                BadRequest();
            }

            var existingArticle = ArticleService.GetArticleById(id);

            if (existingArticle is null)
            {
                NotFound();
            }

            ArticleService.UpdateArticle(article);

            NoContent();
        }

        // DELETE api/<ArticlesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var articleId = ArticleService.GetArticleById(id);

            if (articleId is null)
            {
                NotFound();
            }

            ArticleService.DeleteById(id);

            NoContent();
        }
    }
}
