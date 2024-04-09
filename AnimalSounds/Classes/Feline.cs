using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Feline : Animal
    {
        public override string GetType()
        {
            return "Feline";
        }

        public override string GetSound()
        {
            return "Hiss";
        }
    }
}
