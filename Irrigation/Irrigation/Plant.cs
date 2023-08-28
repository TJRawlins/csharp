using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irrigation
{
    public class Plant
    {

        public int Id { get; set; }
        public bool PlantType { get; set; }
        public string? Name { get; set; }
        public double GalsPerWeek { get; set; }
        public int Quantity { get; set; }
        public int EmittersPerPlant { get; set; }
        public double EmitterGPH { get; set; }
        public int ZoneId { get; set; }

        public override string ToString()
        {
            return $"{Id} | {PlantType} | {Name} | {GalsPerWeek} | {Quantity} | {EmittersPerPlant} | {EmitterGPH} | {ZoneId}";
        }
    }
}
