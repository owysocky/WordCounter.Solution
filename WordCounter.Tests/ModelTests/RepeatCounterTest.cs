using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsEmpty_CheckIfNotEmpty_True()
    {
      RepeatCounter testWord = new RepeatCounter();
      Assert.AreEqual(true, testWord.IsEmpty("a"));
    }



  }
}
