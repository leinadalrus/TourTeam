using AstraleApp.Server.Models;
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

    [HttpPut(Name = "UpdateStaff")]
    public void UpdateStaff()
    {
    }

    [HttpPost(Name = "EditStaff")]
    public void EditStaff(Staff staff)
    {
    }

    [HttpDelete]
    public void DestroyStaff()
    {
    }
  }
}
