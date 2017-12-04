using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Simulation
{
    public class SimualtionCase
    {
        public int CustomerNumber { get; set; }

        public double RandomInterarrivalTime { get; set; }//arrival time

        public int InterarrivalTime { get; set; }

        public int ArrivalTime { get; set; }//clock time

        public double RandomServiceTime { get; set; }

        public int ServiceTime { get; set; }

        public int TimeServiceBegins { get; set; }

        public int TimeServiceEnds { get; set; }

        public int WaitingTime { get; set; }
        public int ServiceDuration;
        public int TotalDelay;
        public int DepartureTime { get; set; }

        public Server AssignedServer { get; set; }
        public Random Rand;
        public int ServerIndex;

    }
}
