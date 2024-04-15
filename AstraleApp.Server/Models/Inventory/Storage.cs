namespace AstraleApp.Server.Models.Inventory
{
  public class Storage
  {
    public Product Product { get; set; }
    public UInt16 Quantity { get; set; }
    public UInt16 Price { get; set; }
    public List<Distributor> Distributors { get; set; }
  }
}
