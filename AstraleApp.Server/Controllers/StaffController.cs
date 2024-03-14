using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class StaffController : Controller
  {
    public StaffController() { }
    
    [HttpGet(Name = "GetStaff")]
    public string GetStaff()
    {
      return "staff";
    }
  }
}
