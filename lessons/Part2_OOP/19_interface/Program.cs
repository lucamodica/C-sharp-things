using System;

namespace interfacee
{

    // Interface
    interface IAnimal 
    {
        void animalSound(); // interface method (does not have a body)
    }

    interface movements
    {
        void moveDX();
        void moveSX();
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal, movements //We can include multiple interfaces, so we can add "movements" interface
    {
        public void animalSound() 
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void moveDX()
        {
            Console.WriteLine("Pig on the right!");
        }

        public void moveSX()
        {
            Console.WriteLine("Pig on the left!");
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.moveDX();
            myPig.moveSX();
        }
    }
}
