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
            Animals cat = new Animals();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}",cat.GetName(), cat.Sound);

            cat.Owner = "Alecu";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

            Console.WriteLine("{0} Shelter id is {1}", cat.GetName(), cat.idNum);

            Console.WriteLine("# of Animals : {0}", Animals.NumOfAnimals);

            Console.ReadLine();
        }
    }
}
