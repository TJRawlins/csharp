using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IBreedSpeak
    {
        // all pets must have at least these properties
        string Species { get; set; } = string.Empty;
        string Breed { get; set; }
        string Speak { get; set; }

    }
}
