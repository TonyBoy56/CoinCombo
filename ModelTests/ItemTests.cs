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
    public void Coin_CreateInstanceOfCoinClass_Coin()
    {
    Coin newCoin = new Coin(1);
    Assert.AreEqual(typeof(Coin), newCoin.GetType());
    }

    [TestMethod]
    public void Coin_SetValueOfCoinAmountInCoinClass_double()
    {
      double amount = .50;
      Coin newCoin = new Coin(amount);
      Assert.AreEqual(.50, amount);
    }

    [TestMethod]
    public void Coin_AccountForNumberOfCoins_double()
    {
      double amount = .80;
      Coin newCoin = new Coin(amount);
      newCoin.CountChange();
      Assert.AreEqual(5, amount);
    }
  }
}
