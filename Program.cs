using System;
namespace Exercise
{
  class Program
  {
    static void Main()
    {
      var runningTotal = 0.0;

      while (true) 
      {
        // Prompt the user for minutes exercised.
        Console.Write("Enter how many minutes you have exercised, or type \"quit\" to exit. ");

        var entry = Console.ReadLine();

        if (entry.ToLower() == "quit")
        {
          break;
        }

        try
        {
          var minutes = double.Parse(entry);
          if (minutes <= 0)
          {
            Console.WriteLine(minutes + " is not an acceptable value.");
            continue;
          }

          else if (minutes <= 10) 
          {
            Console.WriteLine("Hey, that's pretty good.");
          }

          else if (minutes <= 30) 
          {
            Console.WriteLine("You have the heart of a champion!");
          }

          else if (minutes <= 60)
          {
            Console.WriteLine("You must be a ninja in training!");
          }

          else
          {
            Console.WriteLine("Okay, now you're just showing off, but keep it up!");
          }
          // Add minutes exercised to the total.
          runningTotal += minutes;
        }

        catch (FormatException)
        {
          Console.WriteLine("That is invalid input.");
          continue;
        }
        // Display the total minutes exercised to the screen.
        Console.WriteLine("You've exercised for " + runningTotal + " minutes.");

        // Repeat until the user quits the program.
      }

      if (runningTotal == 0) 
      {
        Console.WriteLine("Goodbye, and give it your best next time!");
      }
      else 
      {
        Console.WriteLine("Goodbye, and keep it up!");
      }
    }
  }
}
