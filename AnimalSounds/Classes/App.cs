using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds.Classes
{
    public class App
    {
        private Data dataInstance;

        public App()
        {
            dataInstance = Data.GetInstance();
        }

        public void PrintAnimalSounds()
        {
            List<Animal> animalList = dataInstance.GetAllAnimals();
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.GetType() + " makes sound: " + animal.GetSound());
            }
        }
    }
}
