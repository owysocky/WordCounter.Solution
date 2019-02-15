using System;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {

     Console.WriteLine("====================================");
     Console.WriteLine("COUNT IT");
     Console.WriteLine("Enter a word that you want to count: ");
     string wordInput = Console.ReadLine();
     Console.WriteLine("Enter a sentence that you want to check: ");
     string sentenceInput = Console.ReadLine();
     RepeatCounter countIt = new RepeatCounter();

     bool isEmpty = countIt.IsEmpty(wordInput, sentenceInput);
     if (isEmpty == true)
     {
       Console.WriteLine("The word " + wordInput + " is used " + countIt.WordCount(wordInput, sentenceInput) + " times.");
     }
     else
     {
       Console.WriteLine("I am sorry, you've missed a line!");
     }

     Console.WriteLine("Want to count again? [y/n]");
     string answer = Console.ReadLine();
     if(answer == "y" || answer == "Y")
     {
       Main();
     }
    }
  }
}
