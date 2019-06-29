using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();


            IAnimalSound[] animals = 
           {
                dog,
           };

            foreach (IAnimalSound animal in animals)
            {
                string animalName = animal.GetAnimalName();
                string animalSound = animal.GetAnimalSound();


                string message = $"{animalName} says {animalSound}.";
                Console.WriteLine(message);

            }
            Console.ReadLine();
        }
    }
}
