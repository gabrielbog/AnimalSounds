using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Canine());
            animals.Add(new Feline());
            animals.Add(new Feline());
            animals.Add(new Bird());
            animals.Add(new Bird());

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.GetType() + " makes sound: " + animal.GetSound());
            }

            Console.ReadKey();
        }
    }
}
