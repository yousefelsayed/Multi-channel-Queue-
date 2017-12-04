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
    public partial class InterArriavalTimeDForm : Form
    {
        SimualtionCase sim = new SimualtionCase();
        Server server1 = new Server();
        
        
        public InterArriavalTimeDForm()
        {
            DataBase.Rand = new Random();
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.InterArrivalDistribution = new List<TimeDistribution>();
            DataBase.CustomerNumbers = 0;
            

            try
            {
                DataBase.Servernumber = (int)ServerNum.Value;
                DataBase.ServerMethod = ServermethodChoice.SelectedItem.ToString();
                if (radioButton1.Checked)
                {

                    DataBase.StoppingCondition = true;


                }

                else
                    DataBase.StoppingCondition = false;
                DataBase.StoppingNumber = int.Parse(textBox1.Text);
                float prob = 0,sum=0,minrange=0,maxrange=0;
 
                
                for (int i = 0; i < dataGridView1.RowCount-1; ++i)
                {
                    TimeDistribution TimeDistr1=new TimeDistribution();
                    prob = float.Parse((string)dataGridView1[1, i].Value);
                    if(i==0)
                    {
                        dataGridView1[2, 0].Value = dataGridView1[1, 0].Value;
                        
                        sum = float.Parse( dataGridView1[2, 0].Value.ToString());
                        minrange=1;
                        maxrange=float.Parse( dataGridView1[2, 0].Value.ToString());
                        dataGridView1[3, 0].Value = minrange;
                        dataGridView1[4, 0].Value = maxrange*100;
                    }
                    else
                    {
                        dataGridView1[2, i].Value = sum+prob;
                        
                        minrange = float.Parse(dataGridView1[2, i - 1].Value.ToString())*100 + 1;
                        sum += prob;
                        maxrange = sum*100;
                        dataGridView1[3, i].Value = minrange;
                        dataGridView1[4, i].Value = maxrange;
                        
                    }
                    TimeDistr1.CummProbability = sum;
                    TimeDistr1.Probability = prob;
                    TimeDistr1.MaxRange = maxrange;
                    TimeDistr1.MinRange = minrange;
                    TimeDistr1.Time =  int.Parse(dataGridView1[0, i].Value.ToString());
                   // server1.ServiceTimeDistribution.Add(TimeDistr1);
                    DataBase.InterArrivalDistribution.Add(TimeDistr1);
                }
            
                 ServiceTimeDistributionForm ServiceTimeForm = new ServiceTimeDistributionForm();
                DataBase.ServiceTimeDistribution = new List<List<TimeDistribution>>();
                for (int i = 0; i < DataBase.Servernumber; ++i)
                {
                    DataBase.ServerIndex= i + 1;
                    ServiceTimeForm = new ServiceTimeDistributionForm();
                    ServiceTimeForm.ShowDialog();
                    i = DataBase.ServerIndex - 1;
                }
                ServiceTimeForm.Close();
                Results ResultsForm = new Results();
                ResultsForm.Show();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void InterArriavalTimeDForm_Load(object sender, EventArgs e)
        {
            ServermethodChoice.Text = ServermethodChoice.Items[0].ToString();
        }
    }
}
