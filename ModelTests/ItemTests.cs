using System;
using System.Collections.Generic;
using CoinCombination.Models;
using CoinCombination;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinCombination.Tests
{
  [TestClass]
  public class CoinCombinationTests
  {
    [TestMethod]
    public void CreateCoin_CreateInstance_Coin()
    {
    Coin newCoin = new Coin();
    Assert.AreEqual(typeof(Coin), newCoin.GetType());
    }
  }
}
