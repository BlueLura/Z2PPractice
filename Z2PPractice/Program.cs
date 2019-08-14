using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.NumberOfLegs = 4;
            dog.Name = "Dave";
            dog.Bark();

            Lab lab = new Lab();

            lab.Bark();
            Console.WriteLine(dog.Name);
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }

        public void Eat()
        {

        }
    }

    class Dog : Animal
    {
        public int NumberOfLegs;
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Lab : Dog, IAnimal
    {

    }

    interface IAnimal
    {

    }

}
