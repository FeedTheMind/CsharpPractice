using System; // Added this to complete Task 1.

namespace Challenge.Two
{
  class Program
  {
    static void Main(string[] args)
    {
      // Task 1:
      // The Console class is in the System namespace in the .Net framework. Add a "using" statement
      // to the top of this file to import the System namespace so that the C# compiler knows where
      // to look for the Console class.

      // Task 2:
      // This application won't build because of a syntax error. Fix the code below to make it build.
      Console.WriteLine("Welcome to the code challenges!");
      Console.WriteLine("Press [Enter] to begin..."); // Added semicolon to complete Task 2.
      Console.ReadLine();

      Console.WriteLine("This is the launch application for the first human mission to Mars.");
      Console.Write("Enter the number of seconds you would like to count down from: ");
      // Task 3:
      // Capture the number of seconds that the user would like to count down before liftoff.
      // Hint: You should use another method of the Console class and store the output into a
      // variable to use later.
      var countDown = Int32.Parse(Console.ReadLine()); // Added Parse method to convert from string to numerical data.

      // Task 4:
      // Write a condition to test whether the number that they entered is less than or equal to zero.
      // Call the IsLessThanOrEqualToZero() method below, passing the user's number as a parameter.
      // If the result is true, write "Please enter a positive number." to the console.
      // Hint: The input that you captured is currently a string type. You will have to "parse" it
      // as a different type in order to pass it to the IsLessThanOrEqualToZero function.

      //Task 4 | Task 5
      if (IsLessThanOrEqualToZero(countDown)) 
      {
        while (countDown <= 0) 
        {
          Console.Write("Please enter a positive number. ");
          countDown = Int32.Parse(Console.ReadLine());

          if (countDown > 0) 
          {
            for (var i = countDown; i >= 0; i--) 
            {
              if (i == 0)
              {
                Console.WriteLine(i + " . . . LIFTOFF!");
              }
              else
              {
                Console.WriteLine(i + ", ");
              }
            }
          }
        }
      } 
      
      else if (!(IsLessThanOrEqualToZero(countDown)))
      {
        for (var i = countDown; i >= 0; i--) 
        {
          if (i == 0)
          {
            Console.WriteLine(i + " . . . LIFTOFF!");
          }
          else
          {
            Console.WriteLine(i + ", ");
          } 
        }
      }

      // Task 5:
      // Add an "else" block to the condition from Task 4. This should be run in the case that the
      // number is greater than zero. Write each number to the console, counting backwards, from the 
      // user's number to zero. Then write, "LIFTOFF!".
      // Hint: You can accomplish this with one of several kinds of loops, including "while" and
      // "for".

      Console.WriteLine("Press [Enter] to exit...");
      Console.ReadLine();
    }

    static bool IsLessThanOrEqualToZero(int num)
    {
      return num <= 0;
    }
  }
}
