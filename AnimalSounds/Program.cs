﻿using System;
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
            List<Animal> animals = Debug.getAnimalList();
            Debug.printAnimalSounds(animals);
            Console.ReadKey();
        }
    }
}
