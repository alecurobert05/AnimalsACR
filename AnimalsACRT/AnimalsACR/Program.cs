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
            Animals fox = new Animals()
            {
                name = "Foxy",
                sound = "Raaww"

            };

            Console.WriteLine("# of Animals : {0}", Animals.GetNumAnimals());
            Console.ReadLine();
        }
    }
}
