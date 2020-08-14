using System;
using System.Collections.Generic;
using System.Text;

namespace PhpTravelSiteTests.Helpers
{
    class FlightDetails
    {
        public string From { set; get; }
        public string To { set; get; }
        public string Depart {get; set;}
        public int Adults { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; } 
    }
}
