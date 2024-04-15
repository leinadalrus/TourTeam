namespace AstraleApp.Server.Models
{
  public class IslandKeysInset
  {
    private readonly List<Ship> _ships;

    IslandKeysInset(List<Ship> ships, ushort matriceVectorem)
    {
      _ships = ships;
      MatriceVectorem = matriceVectorem;
    }
    // For first initialisation

    IslandKeysInset(ushort matriceVectorem)
    {
      MatriceVectorem = matriceVectorem;
    }
    // use this constructor if "Ship" model(s) are already instanciated-
    // -inside Insets

    public List<Ship> Ships { get; set; }
    public UInt16 MatriceVectorem { get; set; }
  }
}
