using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic array printing
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Console.WriteLine(cars[0]);

            //Array assignement
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);  

            //Array length
            Console.WriteLine(cars.Length);

            //Looping into an array
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            for (int i = 0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }

            //Looping using foreach
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            } 

            //Sorting an array
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }  

            //Using System.Linq library for arrays
            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());  // largest value
            Console.WriteLine(myNumbers.Min());  // smallest value
            Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
        }
    }
}
