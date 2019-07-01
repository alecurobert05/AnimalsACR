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
            Monkey monkey = new Monkey();
            Cat cat = new Cat();
            Duck duck = new Duck();
            Cow cow = new Cow();
            Lion lion = new Lion();
            Snake snake = new Snake();
            Pig pig = new Pig();


            IAnimalSound[] animals = 
           {
                dog, cat, cow, duck, lion, monkey, pig, snake
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
