using System;
using System.Collections.Generic;
using System.Text;
using Z2PPractice;

namespace ProgrammingChallenge2
{
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string favoriteToy { get; set; }

        public void Speak()
        {
            Console.WriteLine("Meow");
        }

        public void Toy()
        {
            Console.WriteLine($"{Name}'s likes to play with {favoriteToy}.");
        }
    }
}
