using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.DeleteBasket();
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPerUnitCost_ReturnsPerUnitCostOf2_Int()
    {
      Pastry newPastry = new Pastry();
      int cost = newPastry.PerUnitCost;
      Assert.AreEqual(cost, 2);
    }
    [TestMethod]
    public void GetPastryBasket_ReturnsAllInstancesOfPastry_List()
    {
      Pastry Pastry1 = new Pastry();
      Pastry Pastry2 = new Pastry();
      Pastry Pastry3 = new Pastry();
      List<Pastry> expectedPastryBasket = new List<Pastry> { Pastry1, Pastry2, Pastry3 };
      List<Pastry> resultPastryBasket = Pastry.GetPastryBasket();
      CollectionAssert.AreEqual(expectedPastryBasket, resultPastryBasket);
    }
    [TestMethod]
    public void DeleteBasket_DeletesAllInstancesOfPastry_Void()
    {
      Pastry myPastry = new Pastry();
      List<Pastry> expectedPastryBasket = new List<Pastry> { };
      Pastry.DeleteBasket();
      CollectionAssert.AreEqual(expectedPastryBasket, Pastry.GetPastryBasket());
    }
  }
}