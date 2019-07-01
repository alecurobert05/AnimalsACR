using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Lion : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Lion";
        }

        public string GetAnimalSound()
        {
            return "Roooaaaaaaaaaaaarrrrrrrrrrrrr!";
        }
    }
}
