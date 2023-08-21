using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irrigation
{
    internal class Plant
    {
        public string Name { get; set; }
        public int GalPerWeek { get; set; }
        public int Runtime { get; set; }

        public int GalPerMonth() { return GalPerWeek * 4; }
        public int GalPerYear() { return GalPerWeek * 52; }

        public Plant(string Name, int GalPerWeek)
        {
            this.Name = Name;
            this.GalPerWeek = GalPerWeek;
        }
    }
}
