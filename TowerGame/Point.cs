using System;

namespace TowerDefense
{
  class Point
  {
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public int DistanceTo(int x, int y) // This is a method.
    {
      return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
    }

    public int DistanceTo(Point point) // This is an overloaded method.
    {
      return DistanceTo(point.X, point.Y);
    }
  }
}
