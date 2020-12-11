using System;

namespace enumm
{

    //We can consider enum as a class that group constants
    enum Level
    {
        Low,
        Medium,
        High
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}
