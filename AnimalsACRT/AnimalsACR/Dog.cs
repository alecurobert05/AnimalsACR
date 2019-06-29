﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : IAnimalSound
    {
        public string GetAnimalName()
        {
            return "Dog";
        }

        public string GetAnimalSound()
        {
            return "Wooff";
        }
    }
}
