namespace TowerDefense
{
  interface IMappable
  {
    MapLocation Location {get;}
  }

  interface IMovable
  {
    void Move();
  }
  // Note: interfaces don't have constructors; methods and properties don't have implementations.
  interface IInvader : IMappable, IMovable
  {

    int Health {get;}

    bool HasScored {get;}

    bool IsNeutralized {get;}

    bool IsActive {get;}

    void DecreaseHealth(int factor);
  }
}
