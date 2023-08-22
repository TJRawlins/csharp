using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Dog : IBreedSpeak
    {
        public string Species { get; set; } = "Dog";
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Speak { get; set; }

    }
}
