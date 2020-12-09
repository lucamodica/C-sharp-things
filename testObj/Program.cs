using System;

namespace testObj{

    class Program{

        static void Main(string[] args){
            Car car = new Car(5,"red");
            car.Color = "red";
            car.Price = 4.5;
            Console.WriteLine(car.Price);
        }
    }
}
