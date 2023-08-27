﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irrigation
{
    public class Zone
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int RuntimeHours { get; set; }
        public int RuntimeMinutes { get; set; }
        public int RuntimesPerWeek { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {RuntimeHours} | {RuntimeMinutes} | {RuntimesPerWeek}";
        }
    }
}
