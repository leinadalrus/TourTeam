using TourTeam.Server.Components;

namespace TourTeam.Server.Models
{
  public class Customer
  {
    private readonly CustomerDetail _customerDetail = new();

    Customer(CustomerDetail customerDetail)
    {
      _customerDetail = customerDetail;
    }
  }
}
