using System;

namespace numberguess
{
  class Program
  {

    static void Main(string[] args)
    {
      int numberToGuess = 54;
      int userGuess = 0;
      double min = 1;
      double max = 100;
      int treis = 0;
      double current = max / 2;
      Console.WriteLine("Think of a number between " + min + " and " + max);

      while (userGuess != numberToGuess)
      {
        Console.WriteLine("Is your number  " + current);
        Console.WriteLine("yes or lower or higher");
        string input = Console.ReadLine();
        if (input.Equals("yes"))
        {  
          userGuess = numberToGuess;
          Console.WriteLine($" i have guessed the number in {treis} treis !");
        }
        else if (input.Equals("lower"))
        {
          max = current - 1;
          current = Math.Floor((min + max) / 2);
          treis ++;
        }
        else if (input.Equals("higher"))
        {
          min = current + 1;
          current = Math.Floor((min + max) / 2);
          treis ++;
        }



        // if (userGuess > numberToGuess)
        // {
        //   Console.WriteLine("{0} is too high!", userGuess);
        // }
        // else if (userGuess < numberToGuess)
        // {
        //   Console.WriteLine("{0} is too low!", userGuess);
        // }
        // else
        // {
        //   Console.WriteLine("{0} is right! Congratulations.", userGuess);
        // }


      }
    }

    // public static int updateGame(int min, int max)
    // {
    //   int newGuess = Math.Floor((min + max) / 2);
    //   return newGuess;

    // }

  }
}
