using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int PerUnitCost { get; }
    private static List<Bread> _instances = new List<Bread> {};

    public Bread()
    {
      PerUnitCost = 5;
      _instances.Add(this);
    }

    public static List<Bread> GetBreadBasket()
    {
      return _instances;
    }

    public static void DeleteBasket()
    {
      _instances.Clear();
    }
    
  }
}