namespace TowerDefense
{
  class ShieldedInvader : Invader
  {
    public override int Health {get; protected set;} = 2; // Abstract has been changed to override.

    public ShieldedInvader(Path path) : base(path) // This a constructor with a path parameter.
    {

    }

    public override void DecreaseHealth(int factor) // Because this is a subclass, virtual was changed to override.
    {
      if(Random.NextDouble() < .5)
      {
        base.DecreaseHealth(factor);
      }
      else
      {
        System.Console.WriteLine("Shot at a shielded invader, but it sustained zero damage.");
      }
    } 
  }
}
