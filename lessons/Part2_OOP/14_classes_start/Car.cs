using System;

namespace classes_start
{
    class Car
    {
        //Class attributes
        //private string model;
        private string color = "red";
        private int year;

        //Static class attribute (this will be the same for all class instances)
        static int count = 0;

        //Constructor
        public Car(){
            //count++;
            model = "Generic";
            color = "black";
            year = 2020;
        }

        //Contructor with parameter
        public Car(string model, string color, int year){
            //count++;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public string Model{ 
            get; 
            set; 
        }

        //Deconstructor
        //We can't see the WriteLine because the GC excecutes after program termination
        ~Car()
        {
            Console.WriteLine("A car is demolished");
        }

        //Class method
        public void turnOn()
        {
            Console.WriteLine("Auto turned on!");
        }

        //static method (this will be the same for all class instances)
        public static int numCars()
        {
            return count;
        }

    }
}
