namespace TowerDefense
{
  // Below is a class that inherits from System.Exception.
  class TowerDefenseException : System.Exception 
  {
    public TowerDefenseException()
    {
      
    }

    public TowerDefenseException(string message) : base(message)
    {

    }
  }
  class OutOfBoundsException : TowerDefenseException 
  {
    public OutOfBoundsException()
    {

    }

    public OutOfBoundsException(string message) : base(message)
    {

    }
  }
}
