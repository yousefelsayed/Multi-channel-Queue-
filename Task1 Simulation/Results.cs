using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task1_Simulation
{
    public partial class Results : Form
    {
        int timechart = 0;
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            
            Calculation calculation = new Calculation();
            DataBase.Result = new List<SimualtionCase>();
            SimualtionCase tmp = new SimualtionCase();
            DataBase.TotalWaitedTime = 0;
            DataBase.CustomerWaitedNo = 0;
            calculation.SetServers();
            if (DataBase.StoppingCondition == true)
                DataBase.CustomerNumbers = DataBase.StoppingNumber;
            else DataBase.CustomerNumbers = 1000;
            //Calculating intr arrival time 
            for (int i = 1; i <= Math.Min(DataBase.CustomerNumbers, 1000); ++i)
            {
                tmp = new SimualtionCase();
                tmp.CustomerNumber = i;
                //Get Inter Arrival Time
                double RandomDouble = calculation.GenerateRandomDouble();//get random interarriaval time
                tmp.InterarrivalTime = calculation.GetInterArrivalTime(RandomDouble);
                tmp.RandomInterarrivalTime = RandomDouble;
                if (i == 1)
                {
                    tmp.ArrivalTime = 0;
                    tmp.InterarrivalTime = 0;
                }
                else
                {
                    tmp.ArrivalTime = tmp.InterarrivalTime + DataBase.Result[i - 2].ArrivalTime;//clock for arrival time
                }
                tmp.ServerIndex = -1;
                tmp.TimeServiceBegins = -1;
                tmp.TimeServiceEnds = -1;
                DataBase.Result.Add(tmp);
            }


            int Time = 0;

            DataBase.Queue = new List<SimualtionCase>();
            DataBase.MaxLengthQueue = 0;
            HashSet<int> set = new HashSet<int>();
            int MaxEndTime = 0;
            while (true)
            {
                if (DataBase.StoppingCondition == true && set.Count == DataBase.StoppingNumber) break;
                else if (DataBase.StoppingCondition == false && DataBase.StoppingNumber == Time) break;
                for (int i = 0; i < DataBase.Result.Count; ++i)
                {
                    if (!set.Contains(i) && DataBase.Result[i].ArrivalTime <= Time)
                    {
                        int ServerIndex = calculation.ChooseServer();
                        if (ServerIndex != -1)
                        {
                            DataBase.Result[i].ServerIndex = ServerIndex;
                            set.Add(i);
                            DataBase.Servers[ServerIndex - 1].CustormNumbers++;
                            DataBase.Servers[DataBase.Result[i].ServerIndex - 1].available = false;
                            double RandomDouble = calculation.GenerateRandomDouble();
                            DataBase.Result[i].RandomServiceTime = RandomDouble;//RandomServiceTime
                            DataBase.Result[i].ServiceDuration = calculation.GetServiceTime(ServerIndex, RandomDouble);//ServiceDuration
                            DataBase.Result[i].TimeServiceBegins = Time;//TimeServiceBegins
                            DataBase.Result[i].TimeServiceEnds = Time + DataBase.Result[i].ServiceDuration;//TimeServiceEnds
                            DataBase.Result[i].TotalDelay = DataBase.Result[i].TimeServiceBegins - DataBase.Result[i].ArrivalTime;//time in queue
                            if (DataBase.Result[i].TotalDelay > 0) DataBase.CustomerWaitedNo++;
                            DataBase.TotalWaitedTime += DataBase.Result[i].TotalDelay;

                            MaxEndTime = Math.Max(MaxEndTime, DataBase.Result[i].TimeServiceEnds);
                        }
                    }//if service begin ==arrival time
                    if (Time == DataBase.Result[i].ArrivalTime)
                    {
                        DataBase.Queue.Add(DataBase.Result[i]);
                        if (DataBase.Queue.Count > 1)
                        {
                            
                               
                                chart1.Series[0].Points.AddXY((int)Time, (int)DataBase.Queue.Count - 1);
                                timechart = Time;
                                
                            
                            
                        
                            
                        }
                        DataBase.MaxLengthQueue = Math.Max(DataBase.MaxLengthQueue, DataBase.Queue.Count);
                    }
                    else if (Time == DataBase.Result[i].TimeServiceEnds)
                    {
                        for (int j = 0; j < DataBase.Queue.Count; j++)
                        {
                            if (DataBase.Result[i] == DataBase.Queue[j])
                            {
                                DataBase.Servers[DataBase.Queue[j].ServerIndex - 1].available = true;
                                DataBase.Servers[DataBase.Queue[j].ServerIndex - 1].WorkedTime += DataBase.Queue[j].ServiceDuration;
                                DataBase.Queue.RemoveAt(j);
                                --j;
                            }
                        }
                    }
                    /*
                    if (Data.Queue.Count > 1)
                    {
                        CustomersQueue.Series[0].Points.AddXY((int)Time, (int)Data.Queue.Count-1);
                    }*/
                }
                ++Time;
            }
            for (int i = 0; i < DataBase.Servernumber; i++)
            {
                DataBase.Servers[i].IdleTime = MaxEndTime - DataBase.Servers[i].WorkedTime;
            }

            for (int i = 0; i < Math.Min(DataBase.Result.Count, DataBase.CustomerNumbers); ++i)
            {
                TableResult.Rows.Add();
                TableResult.Rows[i].Cells[0].Value = DataBase.Result[i].CustomerNumber; //customer number
                TableResult.Rows[i].Cells[1].Value = Math.Floor(DataBase.Result[i].RandomInterarrivalTime * 100); //Random Digit for arrival
                TableResult.Rows[i].Cells[2].Value = DataBase.Result[i].InterarrivalTime;//inter arrival time
                TableResult.Rows[i].Cells[3].Value = DataBase.Result[i].ArrivalTime; //clock time for arrival
                TableResult.Rows[i].Cells[4].Value = Math.Floor(DataBase.Result[i].RandomServiceTime * 100); //Random digit for service
                TableResult.Rows[i].Cells[5].Value = DataBase.Result[i].ServerIndex;//server index
                TableResult.Rows[i].Cells[6].Value = DataBase.Result[i].TimeServiceBegins;//time service begins
                TableResult.Rows[i].Cells[7].Value = DataBase.Result[i].ServiceDuration; //service time
                TableResult.Rows[i].Cells[8].Value = DataBase.Result[i].TimeServiceEnds;//service time ends
                TableResult.Rows[i].Cells[9].Value = DataBase.Result[i].TotalDelay;//time in queue


                if (DataBase.StoppingCondition == false && DataBase.Result[i].TimeServiceEnds >= DataBase.StoppingNumber) break;
            }

            txtAvgWaiting.Text = ((double)DataBase.TotalWaitedTime / DataBase.CustomerNumbers).ToString();
            MaxQueueLen.Text = Math.Max(DataBase.MaxLengthQueue, DataBase.Queue.Count).ToString();
            WaitInQueue.Text = ((double)DataBase.CustomerWaitedNo / DataBase.CustomerNumbers).ToString();

            for (int i = 0; i < DataBase.Servers.Count; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = DataBase.Servers[i].ServerNo;
                dataGridView2.Rows[i].Cells[1].Value = DataBase.Servers[i].WorkedTime;
                dataGridView2.Rows[i].Cells[2].Value = DataBase.Servers[i].IdleTime;
                if (DataBase.Servers[i].CustormNumbers == 0) dataGridView2.Rows[i].Cells[3].Value = 0;
                else
                    dataGridView2.Rows[i].Cells[3].Value = (double)(DataBase.Servers[i].WorkedTime / DataBase.Servers[i].CustormNumbers);
            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
            for (int kk = 0; kk < DataBase.Servers.Count; kk++)
            {
                Chart Chart1 = new Chart();
                ChartArea ChartArea0 = new ChartArea("name");
                Chart1.ChartAreas.Add(ChartArea0);
                Series Series0 = new Series();
                Chart1.Series.Add(Series0);
                // link series to area here
                Series0.ChartArea = "name";
                chart1.Series[0].Points.AddXY((int)timechart, (int)DataBase.Queue.Count - 1);

            }
                            
        }
    }
}
