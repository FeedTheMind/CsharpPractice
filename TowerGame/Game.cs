using System;

namespace TowerDefense
{
  class Game
  {
    public static void Main()
    {
      Map map = new Map(8, 5); // This is an object. Also, an object is an instance of a class (or type).
      try
      {
        MapLocation mapLocation = new MapLocation(20, 20, map);
      }
      catch(OutOfBoundsException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch(TowerDefenseException)
      {
        Console.WriteLine("Unhandled TowerDefenseException");
      }
      catch(Exception)
      {
        Console.WriteLine("Unhandled Exception"); //This accesses the "custom" message.
      }
    }
  }
}
