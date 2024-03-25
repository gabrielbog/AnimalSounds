using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Debug
    {
        public static List<Animal> getAnimalList()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Canine());
            animals.Add(new Feline());
            animals.Add(new Feline());
            animals.Add(new Bird());
            animals.Add(new Bird());

            return animals;
        }

        public static void printAnimalSounds(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType() + " makes sound: " + animal.GetSound());
            }
        }
    }
}
