using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Canine : Animal
    {
        public override string GetType()
        {
            return "Canine";
        }

        public override string GetSound()
        {
            return "Bark";
        }
    }
}
