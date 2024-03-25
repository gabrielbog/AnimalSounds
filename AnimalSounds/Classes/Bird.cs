using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Bird : Animal
    {
        public override string GetType()
        {
            return "Bird";
        }

        public override string GetSound()
        {
            return "Chirp";
        }
    }
}
