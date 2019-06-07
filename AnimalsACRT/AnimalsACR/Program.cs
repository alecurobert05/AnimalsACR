using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsACR
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals whiskers = new Animals()
            {
                Name = "Whiskers",
                Sound = "Mewo"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = " Woof",
                Sound2 = "Grrr"
            };

            grover.Sound = "Woooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Costin Robert");
            grover.SetAnimalIDInfo(12346, "Georgiana Vilculescu");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animals.AnimalHealth getHealth = new Animals.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            Animals monkey = new Animals()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };

            Animals spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woooooff",
                Sound2 = "Geerrrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
