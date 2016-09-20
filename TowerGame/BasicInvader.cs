namespace TowerDefense
{
  class BasicInvader : Invader
  {

    public override int Health {get; protected set;} = 2; // Abstract has been changed to override.

    public BasicInvader(Path path) : base(path)
    {

    }
  }
}
