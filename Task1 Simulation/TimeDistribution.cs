using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Simulation
{
    public class TimeDistribution
    {
        public int Time { get; set; }

        public double Probability { get; set; }

        public double CummProbability { get; set; }

        public double MinRange { get; set; }

        public double MaxRange { get; set; }
        
        public static Random Rand;
    }
}
