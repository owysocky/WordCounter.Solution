using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord(){return _word;}
    public string GetSentence(){return _sentence;}

    public bool IsEmpty()
    {
      if (String.IsNullOrEmpty(_word))
      {
       return false;
      }
      else if (String.IsNullOrEmpty(_sentence))
      {
       return false;
      }
      else
      {
       return true;
      }
    }

    public int WordCounter()
    {
      string toLowerWord = _word.ToLower().Trim();
      string toLowerCentence = _sentence.ToLower();
      string pattern = @"[^A-Za-z0-9 ]";
      string cleanSentence = System.Text.RegularExpressions.Regex.Replace(toLowerCentence, pattern, string.Empty);

      string[] wordsFromSentance = cleanSentence.Split(' ');
      int counter = 0;

      foreach (string element in wordsFromSentance) {
        if (element == toLowerWord){
          counter ++;
        }
      }
      return counter;
    }
  }
}
