namespace TowerDefense
{
  // "Abstract" keyword creates abstract definition of being an "Invader." Also, Invader doesn't inherit from IInvader; instead, Invader implements IInvader interface.
  abstract class Invader : IInvader 
  {

    private readonly Path _path;

    private int _pathStep = 0; // Initializing a variable to zero is redundant, but it signifies one has thought of what the initial value should be.

    protected virtual int StepSize {get;} = 1;

    public MapLocation Location => _path.GetLocationAt(_pathStep);

    public abstract int Health {get; protected set;}// Abstract implies that subclasses must "override." Also, implementation cannot be added.

    public bool HasScored {get {return _pathStep >= _path.Length;}} // This is a computed property.

    public bool IsNeutralized => Health <= 0;

    public bool IsActive => !(IsNeutralized || HasScored);

    public Invader(Path path)
    {
      _path = path;
    }

    public void Move() => _pathStep += StepSize; // This method is now "syntactic sugar."

    // Virtual implies that this is just one possible implementation of below method, and subclasses can provide own implementations.
    public virtual void DecreaseHealth(int factor) 
    {
      Health -= factor; // This is an example of self-documenting code.
      System.Console.WriteLine("Shot at and hit an invader.");
    }
  }
}
