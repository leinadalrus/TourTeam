using TourTeam.Server.Data;
using TourTeam.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourTeam.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly ConsumerData _consumerData;
        readonly LoginData _loginData;

        public LoginController(ConsumerData consumerData, LoginData loginData)
        {
            _consumerData = consumerData;
            _loginData = loginData;
        }

        // GET: api/<LoginController>
        [HttpGet("{id}"), Authorize]
        public IEnumerable<Consumer> GetConsumerById(Int32 id)
        {
            return _consumerData.Consumers.Where(c => c.Id == id).Select(c =>
            new Consumer
            {
                Id = c.Id,
                Nickname = c.Nickname
            }).AsEnumerable<Consumer>();
        }

        // GET: api/<LoginController>
        [HttpGet("api/[controller]/{username}"), Authorize]
        public IEnumerable<Login> GetConsumerByLogin(String username)
        {
            return _loginData.Logins.Where(l => l.Consumer.Nickname == username).Select(c =>
            new Login
            {
                Consumer = c.Consumer,
                Passphrase = c.Passphrase
            }).AsEnumerable<Login>();
        }

        // PUT api/<LoginController>/5
        [HttpPut("{attribute}/{id}")]
        // POST api/<LoginController>
        [HttpPost("{attribute}/{id}")]
        public IActionResult PostLogin(Int32 id, [FromBody] String attribute)
        {
            if (attribute is null || id <= 0)
            {
                return BadRequest("Invalid client request.");
            }

            if (GetConsumerById(id) != null
                && GetConsumerByLogin(attribute) != null)
            {
                return Ok();
            }

            return Unauthorized();
        }

        // NOTE(Daniel): DELETE api/<LoginController>/5
    }
}
