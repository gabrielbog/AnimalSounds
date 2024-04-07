using AnimalSounds.Classes;
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
            App app = new App();
            app.PrintAnimalSounds();
            Console.ReadKey();
        }
    }
}
