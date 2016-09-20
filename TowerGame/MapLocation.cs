namespace TowerDefense
{
  // Below is a subclass of Point. Also, a subclass inherits all nonprivate members from the other class.
  class MapLocation : Point 
  {
    public MapLocation(int x, int y, Map map) : base(x, y) // MapLocation is a constructor with the base keyword.
    {
      if (!map.OnMap(this)) 
      {
        throw new OutOfBoundsException(this + " is outside the boundaries of the map.");
      }
    }

    public bool InRangeOf(MapLocation location, int range)
    {
      return DistanceTo(location) <= range;
    }
  }
}
