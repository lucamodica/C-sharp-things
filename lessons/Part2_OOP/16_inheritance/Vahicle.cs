using System;

namespace inheritance
{
  class Vehicle  // Base class
  {
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
      Console.WriteLine("Tuut, tuut!");
    }
  }
}