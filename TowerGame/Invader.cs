namespace TowerDefense
{
  class Invader
  {

    private readonly Path _path;

    private int _pathStep = 0; //Initializing a variable to zero is redundant, but it signifies one has thought of what the initial value should be.

    public MapLocation Location => _path.GetLocationAt(_pathStep);

    public int Health {get; private set;} = 2;

    public bool HasScored {get {return _pathStep >= _path.Length;}}

    public bool IsNeutralized => Health <= 0;

    public bool IsActive => !(IsNeutralized || HasScored);

    public Invader(Path path)
    {
      _path = path;
    }

    public void Move() => _pathStep += 1; // This method is now "syntactic sugar."

    public void DecreaseHealth(int factor) 
    {
      Health -= factor; // This is an example of self-documenting code.
    }
  }
}
