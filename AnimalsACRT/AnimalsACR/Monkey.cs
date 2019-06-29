using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Monkey : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Monkey";

        }

        public string GetAnimalSound()
        {
            return "woohh woohh";
        }
    }
}
