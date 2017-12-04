using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Simulation
{
    class Calculation
    {
        public double GenerateRandomDouble()
        {
            double RandomDouble = 0;
            RandomDouble = DataBase.Rand.NextDouble();
            return RandomDouble;
        }
        public int GenerateRandomInt(int a, int b)
        {
            int RandomInt = 0;
            RandomInt = DataBase.Rand.Next(a, b);
            return RandomInt;
        }
        public int GetInterArrivalTime(double RandomNum)
        {
            int InterArrivalTime = 1;
            for (int i = 0; i < DataBase.InterArrivalDistribution.Count; i++)
            {
               if( DataBase.InterArrivalDistribution[i].CummProbability>= RandomNum)
                //if (Math.Floor(DataBase.InterArrivalDistribution[i].MinRange * 1) <= Math.Floor(RandomNum * 100) && Math.Floor(DataBase.InterArrivalDistribution[i].CummProbability * 100) <= Math.Floor(RandomNum * 100))
                {
                    InterArrivalTime = DataBase.InterArrivalDistribution[i].Time;
                    break;
                }
            }
            return InterArrivalTime;
        }
        public int GetServiceTime(int ServerIndex, double RandomNum)
        {
            int ServiceTime = 0;
            for (int i = 0; i < DataBase.ServiceTimeDistribution[ServerIndex-1].Count; i++)
            {
                //if (Math.Floor(DataBase.ServiceTimeDistribution[ServerIndex - 1][i].MinRange)==1) {
                //    ServiceTime = DataBase.ServiceTimeDistribution[ServerIndex - 1][i].Time;
                //}
                if(DataBase.ServiceTimeDistribution[ServerIndex - 1][i].CummProbability >= RandomNum)
                //if (Math.Floor(DataBase.ServiceTimeDistribution[ServerIndex - 1][i].MinRange * 100) <= Math.Floor(RandomNum * 100) && Math.Floor(DataBase.ServiceTimeDistribution[ServerIndex - 1][i].CummProbability * 100) >= Math.Floor(RandomNum * 100))
                {
                    ServiceTime = DataBase.ServiceTimeDistribution[ServerIndex - 1][i].Time;
                    break;
                }
            }
            if (ServiceTime == 0)
              //  return 1;
                ServiceTime = DataBase.ServiceTimeDistribution[ServerIndex - 1][DataBase.ServiceTimeDistribution.Count - 1].Time;
            return ServiceTime;
        }
        public void SetServers()
        {
            Server Server;
            DataBase.Servers = new List<Server>();
            for (int i = 0; i < DataBase.Servernumber; i++)
            {
                Server = new Server();
                Server.available = true;
                Server.ServerNo = i + 1;
                Server.WorkedTime = Server.IdleTime = Server.CustormNumbers = 0;
                DataBase.Servers.Add(Server);
            }
        }
        public int ChooseServer()
        {
            int ServerIndex = -1;
            if (DataBase.ServerMethod == "Random")
            {
                int RandInt = GenerateRandomInt(1, DataBase.Servernumber + 1);
                HashSet<int> set = new HashSet<int>();
                while (DataBase.Servers[RandInt - 1].available == false)
                {
                    set.Add(RandInt);
                    RandInt = GenerateRandomInt(1, DataBase.Servernumber + 1);

                    if (set.Count == DataBase.Servernumber)
                        return -1;
                }
                ServerIndex = RandInt;
            }
            else if (DataBase.ServerMethod == "Highest Priority") 
            {
                for (int i = 0; i < DataBase.Servernumber; i++)
                {
                    if (DataBase.Servers[i].available)
                    {
                        ServerIndex = DataBase.Servers[i].ServerNo;
                        break;
                    }
                }
            }
            else // lowest worked time
            {
                DataBase.Servers = DataBase.Servers.OrderBy(x => x.WorkedTime).ToList();
                for (int i = 0; i < DataBase.Servernumber; i++)
                {
                    if (DataBase.Servers[i].available)
                    {
                        ServerIndex = DataBase.Servers[i].ServerNo;
                        break;
                    }
                }
            }
            return ServerIndex;
        }
    }
}
