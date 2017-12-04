using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Simulation
{
    public class Enums
    {
        public enum ServerSelectionMethod
        {
            HighestPriority = 0,
            LowestUtilization = 1,
            Random = 2
        }

        public enum ServerStoppingCondition
        {
            NumberOfCustomers = 0,
            SimulationEndTime = 1
        }
    }
}
