namespace AstraleApp.Server.Models.Inventory
{
  public class Product
  {
    public UInt16 ID { get; set; }
    public UInt16 SerialNo { get; set; }
    public String Name { get; set; }
    public String Make { get; set; }
    public String Series { get; set; }
    public DateTime ExpirationDate { get; set; }
  }
}
