using Microsoft.AspNetCore.Mvc;

namespace TourTeam.Server.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("{id}")]
        public Int32 Index(Int32 id)
        {
            return id;
        }

        [HttpGet("/")]
        public String Index()
        {
            return "Index";
        }
    }
}
