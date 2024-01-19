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
      _instances.Add(this);
    }

    public static List<Pastry> GetPastryBasket()
    {
      return _instances;
    }

    public static void DeleteBasket()
    {
      _instances.Clear();
    }

    public static int GetBasketTotal(int pastries)
    {
      int totalCost = 0;
      int discountChecker = 0;
      for (int i = 0; i < pastries; i++)
      {
        Pastry newPastry = new Pastry();
        totalCost += newPastry.PerUnitCost;
        discountChecker += 1;
        if (discountChecker == 4)
        {
          discountChecker = 0;
          totalCost -= newPastry.PerUnitCost;
        }
      }
      return totalCost;
    }
  }
}
