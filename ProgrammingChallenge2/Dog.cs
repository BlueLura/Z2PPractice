using System;
using System.Collections.Generic;
using System.Text;
using Z2PPractice;

namespace ProgrammingChallenge2
{
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("Bark");
        }

        public void HowOld()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

    }
}
