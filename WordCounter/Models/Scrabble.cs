using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class Scrabble {
    private string one = "AEIOULNRST";
    private string two = "DG";
    private string three = "BCMP";
    private string four = "FHVWY";
    private string five = "K";
    private string eight = "JX";
    private string ten = "QZ";
    private string _word;

    public Scrabble(string word){
      _word = word;
    }
    
    public string GetWord(){return _word;}

    public int ScoreCount()
    {
      string wordUpper = _word.ToUpper();

      int score = 0;

      foreach (char c in wordUpper) {
        string cString = c.ToString();
        if(one.Contains(cString))
        {
          score+=1;
        }
        else if(two.Contains(cString))
        {
          score+=2;
        }
        else if(three.Contains(cString))
        {
          score+=3;
        }
        else if(four.Contains(cString))
        {
          score+=4;
        }
        else if(five.Contains(cString))
        {
          score+=5;
        }
        else if(eight.Contains(cString))
        {
          score+=8;
        }
        else if(ten.Contains(cString))
        {
          score+=10;
        }
        else
        {
          return score;
        }
      }

      return score;
    }
  }
}
