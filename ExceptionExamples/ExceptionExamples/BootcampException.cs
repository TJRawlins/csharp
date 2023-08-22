using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    internal class BootcampException : Exception
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        //DEFAULT CONSTRUCTOR
        public BootcampException() : base() { }
        public BootcampException(string message) : base(message) { }
        public BootcampException(string message, Exception innerException) : base (message, innerException) { }
    }
}
