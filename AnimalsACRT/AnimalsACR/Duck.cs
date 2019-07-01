using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Duck : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Duck";

        }

        public string GetAnimalSound()
        {
            return "Quack Quack";

        }
    }
}
