
namespace AstraleApp.Server.Models.Inventory
{
  public class Distributor : Buyer
  {
    public Distributor(
      ushort accountID,
      ushort accountBalance,
      ushort businessNumber,
      string businessName,
      DateTime creationDate
    ) : base(
      accountID,
      accountBalance,
      businessNumber,
      businessName,
      creationDate
    )
    {
    }
  }
}
