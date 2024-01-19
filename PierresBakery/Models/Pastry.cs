using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PerUnitCost { get; }
    private static List<Pastry> _instances = new List<Pastry> { };

    public Pastry()
    {
      PerUnitCost = 2;
    }

    public static List<Pastry> GetPastryBasket()
    {
      return _instances;
    }

    public static void DeleteBasket()
    {
      _instances.Clear();
    }
  }
}