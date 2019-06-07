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

            Console.ReadLine();
        }
    }
}
