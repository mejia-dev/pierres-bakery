using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
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
    [TestMethod]
    public void GetBasketTotal_ReturnsTotalCostOfBasketWhereEveryThirdBreadIs0_Int()
    {
      Assert.AreEqual(Bread.GetBasketTotal(2), 10);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(3), 10);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(4), 15);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(5), 20);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(6), 20);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(7), 25);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(8), 30);
      Bread.DeleteBasket();
      Assert.AreEqual(Bread.GetBasketTotal(9), 30);
    }
  }
}
