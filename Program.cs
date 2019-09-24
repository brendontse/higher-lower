
using System;
using System.Collections.Generic;

namespace higher_lower
{
  class Game
  {
    public int MaxNumber;
    public int MinNumber;
    public string UserInput;

    public Game(int minNumber, int maxNumber)
    {
      MinNumber = minNumber;
      MaxNumber = maxNumber;
    }
  }

  class Program
  {
    static void Main()
    {
      Game highlow = new Game(0, 101);
      
      bool gameNotOver = true;

      do 
        { 
        int guess = (highlow.MaxNumber + highlow.MinNumber) / 2;

        Console.WriteLine("Is your number " + guess + ", or is it higher/lower?");
        string userInput = Console.ReadLine();

        if (userInput == "higher")
        {
          highlow.MinNumber = guess;
        }
        else if (userInput == "lower")
        {
          highlow.MaxNumber = guess;
        }
        else if (userInput == "yes")
        {
          Console.WriteLine("I win");
          gameNotOver = false;
        }
        else 
        {
          Console.WriteLine("Please tell me whether your number is higher, lower, or yes.");
        }
      }
      while (gameNotOver);
    }
  }
}