using System;

namespace classes_start
{
    class Program
    {

        static void Main(string[] args)
        {
            //Creating instances of the Car class
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            //Print their color attribute
            Console.WriteLine(myObj1.color); 
            Console.WriteLine(myObj2.color); 
            //Print something with an obj method
            myObj1.turnOn();

            //Assigning attribute values to an object
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;
            Console.WriteLine(Ford.model);            
            Console.WriteLine(Ford.color);            
            Console.WriteLine(Ford.year);

            //Creating a Car instance with a constructor with no parameters
            Car oldCar = new Car();
            Console.WriteLine(oldCar.year);
            
            //Creating a Car instance with a constructor with parameters
            Car Ferrari = new Car("Ferrari","Red",2020);
            Console.WriteLine(Ferrari.color + " " + Ferrari.year + " " + Ferrari.model);     

            //Calling a static method
            Console.WriteLine("Number of cars in this program: " + Car.numCars());

        }
    }
}
