using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.DeleteBasket();
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPerUnitCost_ReturnsPerUnitCostOf5_Int()
    {
      Bread newBread = new Bread();
      int cost = newBread.PerUnitCost;
      Assert.AreEqual(cost, 5);
    }
    [TestMethod]
    public void GetBreadBasket_ReturnsAllInstancesOfBread_List()
    {
      Bread Bread1 = new Bread();
      Bread Bread2 = new Bread();
      Bread Bread3 = new Bread();
      List<Bread> expectedBreadBasket = new List<Bread> { Bread1, Bread2, Bread3 };
      List<Bread> resultBreadBasket = Bread.GetBreadBasket();
      CollectionAssert.AreEqual(expectedBreadBasket, resultBreadBasket);
    }
    [TestMethod]
    public void DeleteBasket_DeletesAllInstancesOfBread_Void()
    {
      Bread myBread = new Bread();
      List<Bread> expectedBreadBasket = new List<Bread> {};
      Bread.DeleteBasket();
      CollectionAssert.AreEqual(expectedBreadBasket, Bread.GetBreadBasket());
    }
  }
}