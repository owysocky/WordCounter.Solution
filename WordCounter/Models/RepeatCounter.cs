using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    public bool IsEmpty(string word, string sentence)
    {
      if (String.IsNullOrEmpty(word))
      {
       return false;
      }
      else if (String.IsNullOrEmpty(sentence))
      {
       return false;
      }
      else
      {
       return true;
      }
    }

    public int WordCount(string word, string sentence)
    {
      string toLowerWord = word.ToLower();
      string toLowerCentence = sentence.ToLower();
      string[] wordsFromSentance = toLowerCentence.Split(' ');
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
