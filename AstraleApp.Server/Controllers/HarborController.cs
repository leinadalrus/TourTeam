using AstraleApp.Server.Models.Graphs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
    [ApiController]
  [Route("api/[controller]")]
  public class HarborController : Controller
  {
    private IslandKeysInset _islandKeysInset;

    public HarborController(IslandKeysInset islandKeysInset)
    {
      _islandKeysInset = islandKeysInset;
    }

    [HttpGet(Name = "GetIslandKeysInset")]
    public String GetIslandKeysInset()
    {
      return "IslandKeysInset";
    }
  }
}
