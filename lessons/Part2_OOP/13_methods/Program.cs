using System;

namespace methods
{
    class Program
    {

        //Method without parameters
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        //Method with parameters
        static void greating(string fname, int age) 
        {
            Console.WriteLine("Hello, " + fname + "!\n Your age is " + age);
        }

        //Method with initialized parameters
        static void countries(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        //Method with return value
        static int sum(int x, int y)
        {
            return x + y;
        }

        //Method with named parameters
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        //Method sum, overloaded for double type
        static double sum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //MyMethod excecutions
            MyMethod();
            MyMethod();
            MyMethod();

            //greating excecutions
            greating("Luca",20);
            greating("Enrico",21);
            greating("Anna",19);

            //countries excecutions
            countries("USA");
            countries();
            countries("India");

            //sum excecution
            int z = sum(3,5);
            Console.WriteLine(z);

            //MyChild excecution
            MyMethod(child3: "John", child1: "Liam", child2: "Liam"); //Parameters order does not matter

            //sum excecution (overloaded for double)
            double d = sum(3.14,5.06);
            Console.WriteLine(d);


        }
    }
}
