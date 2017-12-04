using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1_Simulation
{
    class DataBase
    {
        public static bool StoppingCondition;
        public static int StoppingNumber;
        public List<TimeDistribution> InterArrivalTimeDist;
        public static List<List<TimeDistribution>> ServiceTimeDistribution;
        public static Random Rand;
        public static List<TimeDistribution> InterArrivalDistribution;
        public static List<Server> Servers;
        public static int Servernumber;
        public static string ServerMethod;
        public static List<SimualtionCase> Result;
        public static List<SimualtionCase> Queue;
        public static int MaxLengthQueue;
        public static int TotalWaitedTime;
        public static int CustomerWaitedNo;
        public static int CustomerNumbers;
        public static int ServerIndex;
        
    }
}
