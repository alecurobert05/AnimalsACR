using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Snake : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Snake";

        }

        public string GetAnimalSound()
        {
            return "ssssssssssssss";

        }
    }
}
