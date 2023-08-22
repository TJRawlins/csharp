using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Cat : IBreedSpeak
    {
        public string Species { get; set; } = "Cat";
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Speak { get; set; }
    }
}
