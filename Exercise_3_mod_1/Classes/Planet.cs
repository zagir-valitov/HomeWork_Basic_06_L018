﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_mod_1.Classes
{
    internal class Planet
    {
        public string? Name { get; set; }
        public int SequenceNumber { get; set; }
        public int LengthEquator { get; set; }
        public Planet? PreviousPlanet { get; set; }
    }
}