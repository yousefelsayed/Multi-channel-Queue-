using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Simulation
{
    public class Server
    {
        public Server()
        {
            ServiceTimeDistribution = new List<TimeDistribution>();
        }
        public int ServerId { get; set; }

        public string Name { get; set; }

        public double ServiceEfficiency { get; set; }
        public bool StoppingCondtion { get; set; }
        public int StoppingNumber { get; set; }
        public  bool available;
        public int ServerNo;
        
        public int WorkedTime;
        public int IdleTime;
        public int CustormNumbers;
        public List<TimeDistribution> ServiceTimeDistribution { get; set; }
        public static List<List<TimeDistribution>> ServiceTimeDistribution1;

    }
}
