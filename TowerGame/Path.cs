namespace TowerDefense
{
  class Path
  {
    private readonly MapLocation[] _path;

    public int Length => _path.Length;

    public Path(MapLocation[] path) 
    {
      _path = path;
    }

    public MapLocation GetLocationAt(int pathStep)
    {
      return (pathStep < _path.Length) ? _path[pathStep] : null; // Null is the absence of a value. Also, this is a ternary operator. 
    }

    public bool IsOnPath(MapLocation location)
    {
      foreach(var pathLocation in _path)
      {
        if(location.Equals(pathLocation)) // Checks to see if objects are the same.
        {
          return true;
        }
      }
      return false;
    }
  }
}
