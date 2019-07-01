using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Cow";

        }

        public string GetAnimalSound()
        {
            return "Mmmmooooooooo";

        }
    }
}