using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Advanced.Classes
{
    internal class Planet
    {
        public string? Name { get; set; }
        public int SequenceNumber { get; set; }
        public int LengthEquator { get; set; }
        public Planet? PreviousPlanet { get; set; }
    }
}
