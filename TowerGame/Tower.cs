using System;

namespace TowerDefense
{
  class Tower
  {

    protected virtual int Range {get;} = 1; // Because it's a protected property, use uppercase letter. Side note: An underscore before a private variable is common convention.
    protected virtual int Power {get;} = 2;

    protected virtual double Accuracy {get;} = .75;


    private readonly MapLocation _location;

    public bool IsSuccessfulShot()
    {
      return Random.NextDouble() < Accuracy;
    }

    public Tower(MapLocation location)
    {
      _location = location;
    }

    public void FireOnInvaders(IInvader[] invaders)
    {

      foreach(IInvader invader in invaders)
      {
        if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
        {
          if(IsSuccessfulShot())
          {
            invader.DecreaseHealth(Power);
            
            if(invader.IsNeutralized)
            {
              Console.WriteLine("Invader has been neutralized at " + invader.Location + ".");
            }
          } 
          else 
          {
            Console.WriteLine("Shot at and missed invader.");
          }
          
          break;
        }
      }
    }
  }
}
