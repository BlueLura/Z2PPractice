using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing.");
        }

        public void Eat()
        {
            Console.WriteLine("Nom nom.");
        }
    }

    class Dog : Animal
    {
        public int NumberOfLegs { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    class Fish : Animal
    {

    }
}
