using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int PerUnitCost { get; }
    private static List<Bread> _instances = new List<Bread> { };

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

    public static int GetBasketTotal(int loaves)
    {
      int totalCost = 0;
      int discountChecker = 0;
      for (int i = 0; i < loaves; i++)
      {
        Bread newLoaf = new Bread();
        totalCost += newLoaf.PerUnitCost;
        discountChecker += 1;
        if (discountChecker == 3)
        {
          discountChecker = 0;
          totalCost -= newLoaf.PerUnitCost;
        }
      }
      return totalCost;
    }
  }
}
