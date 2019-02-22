using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
     [TestMethod]
     public void ScoreCount_CountScore_True()
     {
       string myWord = "j";
       Scrabble testLetter = new Scrabble(myWord);
       Assert.AreEqual(8, testLetter.ScoreCount());
     }

     [TestMethod]
     public void ScoreCount_CountScoreSecond_True()
     {
       string myWord = "jk";
       Scrabble testLetter = new Scrabble(myWord);
       Assert.AreEqual(13, testLetter.ScoreCount());
     }
  }
}
