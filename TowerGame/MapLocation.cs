namespace TowerDefense
{
  // Below is a subclass of Point.
  class MapLocation : Point 
  {
    public MapLocation(int x, int y, Map map) : base(x, y) // MapLocation is a constructor with the base keyword.
    {
      if (!map.OnMap(this)) 
      {
        throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
      }
    }
  }
}
