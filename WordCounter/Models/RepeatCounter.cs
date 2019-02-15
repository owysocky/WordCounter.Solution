using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    public bool IsEmpty(string word)
    {
      if (String.IsNullOrEmpty(word))
      {
       return false;
      }
      else
      {
       return true;
      }
    }
  }
}
