using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Simulation
{
    public partial class ServiceTimeDistributionForm : Form
    {
        SimualtionCase sim = new SimualtionCase();
        Server server1 = new Server();
        
        public ServiceTimeDistributionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               List<TimeDistribution> tmp=new List<TimeDistribution>();
               TimeDistribution TimeDistr = new TimeDistribution();
                float prob = 0,sum=0,minrange=0,maxrange=0;
                for (int i = 0; i < ServiceTimeDGV.RowCount-1; ++i)
                {
                    TimeDistr=new TimeDistribution() ;
                    
                     prob = float.Parse(ServiceTimeDGV[1, i].Value.ToString());
                    if(i==0)
                    {
                        ServiceTimeDGV[2, 0].Value = ServiceTimeDGV[1, 0].Value;
                        sum = float.Parse(ServiceTimeDGV[2, 0].Value.ToString());
                        minrange=1;
                        maxrange=float.Parse(ServiceTimeDGV[2, 0].Value.ToString());
                        ServiceTimeDGV[3, 0].Value = minrange;
                        ServiceTimeDGV[4, 0].Value = maxrange * 100;
                    }
                    else
                    {
                        ServiceTimeDGV[2, i].Value = sum + prob;

                        minrange = float.Parse(ServiceTimeDGV[2, i - 1].Value.ToString()) * 100 + 1;
                        sum += prob;
                        maxrange = sum * 100;
                        ServiceTimeDGV[3, i].Value = minrange;
                        ServiceTimeDGV[4, i].Value = maxrange;
                    }
                    TimeDistr.Time = int.Parse(ServiceTimeDGV[0, i].Value.ToString());
                    TimeDistr.Probability = prob;
                    TimeDistr.MinRange = minrange;
                    TimeDistr.MaxRange = maxrange;
                    TimeDistr.CummProbability = sum;
                    tmp.Add(TimeDistr);
                    
                }
                DataBase.ServiceTimeDistribution.Add(tmp);
               this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ServiceTimeDistributionForm_Activated(object sender, EventArgs e)
        {
            label1.Text = "Service Time Distribution For Server " + DataBase.ServerIndex.ToString();
        }

        private void ServiceTimeDistributionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DataBase.ServerIndex = (int)1e9;
            }
            try
            {
                int n = ServiceTimeDGV.RowCount;
                for (int i = 0; i < n; ++i)
                {
                    ServiceTimeDGV.Rows.RemoveAt(0);
                }
            }
            catch
            {
            }
        }
    }
}
