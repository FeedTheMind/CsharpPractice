using System;

namespace TowerDefense
{
  class Game
  {
    public static void Main()
    {
      Map map = new Map(8, 5); // This is an object. Also, an object is an instance of a class (or type).
      Point point = new Point(4, 2);
      
      Console.WriteLine(point.DistanceTo(5, 5));
    }
  }
}
