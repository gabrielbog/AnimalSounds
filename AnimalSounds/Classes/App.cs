using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds.Classes
{
    public class App
    {
        private List<Animal> animalList;

        public App()
        {
            animalList = GetAnimalList();
        }

        private List<Animal> GetAnimalList()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Canine());
            animals.Add(new Feline());
            animals.Add(new Feline());
            animals.Add(new Bird());
            animals.Add(new Bird());
            return animals;
        }

        public void PrintAnimalSounds()
        {
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.GetType() + " makes sound: " + animal.GetSound());
            }
        }
    }
}
