using System;

namespace ProgrammingChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Spikey";
            dog.Age = 3;

            Cat cat = new Cat();
            cat.Name = "Frumpkin";
            cat.favoriteToy = "yarn";

            dog.Speak();
            cat.Speak();

            dog.HowOld();
            cat.Toy();

        }
    }
}
