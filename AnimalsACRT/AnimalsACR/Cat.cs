﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Cat";
        }

        public string GetAnimalSound()
        {
            return "Meow";
        }
    }
}
