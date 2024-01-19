using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
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
  }
}