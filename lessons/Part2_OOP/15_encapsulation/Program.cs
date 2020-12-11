using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model); //This attribute can be accessed with getter func
            Console.WriteLine(myObj.color); //This attribute can be accessed because is public
            Console.WriteLine(myObj.Name); //This attribute can be accessed with short-hand getter func

        }
    }
}
