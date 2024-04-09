using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds.Classes
{
    public class Data
    {
        private static Data inst = null;
        private List<Animal> animalList;
        private Data()
        {
            LoadData();
        }

        public static Data GetInstance()
        {
            if (inst == null)
                inst = new Data();
            return inst;
        }

        private void LoadData()
        {
            animalList = new List<Animal>();
            animalList.Add(new Canine());
            animalList.Add(new Feline());
            animalList.Add(new Feline());
            animalList.Add(new Bird());
            animalList.Add(new Bird());
        }

        public List<Animal> GetAllAnimals()
        {
            return animalList;
        }
    }
}
