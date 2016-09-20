namespace TowerDefense
{
  class FastInvader : Invader
  {

    protected override int StepSize {get;} = 2;

    public override int Health {get; protected set;} = 2; // Abstract has been changed to override.

    public FastInvader(Path path) : base(path)
    {

    }
  }
}
