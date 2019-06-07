using System;


namespace AnimalsACR
{
    class Animals
    {
        public string name;
        public string sound;

        public Animals()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animals(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animals(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        
        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

    }
}
