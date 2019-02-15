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
      Assert.AreEqual(true, testWord.IsEmpty("a", "a"));
    }

    [TestMethod]
    public void WordCount_WordCountsWord_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(1, testCount.WordCount("a", "a"));
    }

    [TestMethod]
    public void WordCount_WordCountsNumbers_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(1, testCount.WordCount("1", "1"));
    }

    [TestMethod]
    public void WordCount_CaseInsensitiveCount_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(1, testCount.WordCount("A", "a"));
    }

    [TestMethod]
    public void WordCount_WordCountsSentence_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(2, testCount.WordCount("A", "A cat a dog"));
    }

    [TestMethod]
    public void WordCount_WordCountsSentenceRegardlessPunctuation_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(2, testCount.WordCount("cat", "A cat, a CAT!"));
    }

    [TestMethod]
    public void WordCount_WordCountsWithoutWhiteSpaces_True()
    {
      RepeatCounter testCount = new RepeatCounter();
      Assert.AreEqual(2, testCount.WordCount("  cat ", "A cat, a CAT!"));
    }


  }
}
