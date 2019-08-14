using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Bob"); // Name must be set internally

            Console.WriteLine(myAnimal.Name);
            
        }
    }
    
    class Animal
    {
        public string Name { get; } // Set is only accessed through the constructor

        public Animal()
        {
            Name = "No name";
        }
        public Animal(string name) // Requires a string to be used with the constructor
        {
            Name = name;
        }
    }
}
