using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Hamster : IBreedSpeak
    {

        public string Species { get; set; } = "Hampster";
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Speak { get; set; }  
    }
}
