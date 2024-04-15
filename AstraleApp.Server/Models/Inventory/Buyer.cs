namespace AstraleApp.Server.Models.Inventory
{
  public class Buyer
  {
    UInt16 _accountID
    {
      get; set;
    }
    UInt16 _accountBalance
    {
      get; set;
    }
    UInt16 _businessNumber
    {
      get; set;
    }
    String _businessName
    {
      get; set;
    }
    DateTime _creationDate
    {
      get; set;
    }

    public Buyer(
      ushort accountID,
      ushort accountBalance,
      ushort businessNumber,
      string businessName,
      DateTime creationDate
    )
    {
      _accountID = accountID;
      _accountBalance = accountBalance;
      _businessNumber = businessNumber;
      _businessName = businessName;
      _creationDate = creationDate;
    }
  }
}
