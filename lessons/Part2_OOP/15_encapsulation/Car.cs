using System;

namespace encapsulation
{
  class Car
  {
    private string model = "Mustang"; //Private attribute
    private string color = "Red"; //public attribute (bas practise for security)

    public string Model    //Getter and setter to make "model" attribute accessible
    {
      get { return model; }
      set { name = value; }
    }

    public string Name    //Short-hand getter and setter
    { get; set; } 

  }
}
