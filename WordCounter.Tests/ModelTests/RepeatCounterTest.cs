using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsEmpty_CheckIfNotEmpty_True()
    {
      string myWord = "a";
      string mySentence = "a";
      RepeatCounter myCounter = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(true, myCounter.IsEmpty());
    }

    [TestMethod]
    public void WordCount_WordCountsWord_True()
    {
      string myWord = "a";
      string mySentence = "a";
      RepeatCounter testCount = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(1, testCount.WordCounter());
    }

    [TestMethod]
    public void WordCount_WordCountsNumbers_True()
    {
      string myWord = "1";
      string mySentence = "1";
      RepeatCounter testCount = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(1, testCount.WordCounter());
    }

    [TestMethod]
    public void WordCount_CaseInsensitiveCount_True()
    {
      string myWord = "a";
      string mySentence = "A";
      RepeatCounter testCount = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(1, testCount.WordCounter());
    }

    [TestMethod]
    public void WordCount_WordCountsSentence_True()
    {
      string myWord = "A";
      string mySentence = "A cat a dog";
      RepeatCounter testCount = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(2, testCount.WordCounter());
    }

    [TestMethod]
    public void WordCount_WordCountsSentenceRegardlessPunctuation_True()
    {
      string myWord = "cat";
      string mySentence = "A cat, a CAT!";
      RepeatCounter testCount = new RepeatCounter(myWord, mySentence);
      Assert.AreEqual(2, testCount.WordCounter());
    }
  }
}
