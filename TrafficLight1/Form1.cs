using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLight1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statusA1.Text = "";
            statusA2.Text = "";
            statusB1.Text = "";
            statusB2.Text = "";
            labelInf.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerA1.Stop();
            timerA2.Stop();
            timerB1.Stop();
            timerB2.Stop();
        }

        int cycle = 0;
        bool enA = false;
        bool enB = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            defaultDistribution();
            
            if (enA)
            {
                timerA1.Stop();
                timerA2.Stop();
                timerB1.Start();
                timerB2.Start();
                if (statusA1.Text.Length >= 1)
                    statusA1.Text = statusA1.Text.Substring(0, statusA1.Text.Length - 1);
                if (statusA2.Text.Length >= 1)
                    statusA2.Text = statusA2.Text.Substring(0, statusA2.Text.Length - 1);
            }

            if (enB)
            {
                timerB1.Stop();
                timerB2.Stop();
                timerA1.Start();
                timerA2.Stop();
                if (statusB1.Text.Length >= 1)
                    statusB1.Text = statusB1.Text.Substring(0, statusB1.Text.Length - 1);
                if (statusB2.Text.Length >= 1)
                    statusB2.Text = statusB2.Text.Substring(0, statusB2.Text.Length - 1);
            }
            
            if (!enA && !enB)
            {
                timerA1.Start();
                timerA2.Start();
                timerB1.Start();
                timerB2.Start();
            }
        }

        private void TimerA1_Tick(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            timerA1.Interval = rnd1.Next(800, 3000);    //It's changeable according to traffic 
            statusA1.Text += "•";
        }

        private void TimerA2_Tick(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            timerA2.Interval = rnd2.Next(800, 3000);
            statusA2.Text += "•";
        }

        private void TimerB1_Tick(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            timerB1.Interval = rnd1.Next(800, 3000);
            statusB1.Text += "•";
        }

        private void TimerB2_Tick(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            timerB2.Interval = rnd2.Next(800, 3000);
            statusB2.Text += "•";
        }

        public void defaultDistribution()
        {
            cycle += 1;
            if (cycle == 15)
                cycle = 0;
            labelInf.Text = "" + cycle;
            switch (cycle)      //Default cycles
            {
                case 1:     //Street A
                    label2.ForeColor = Color.Green;
                    label5.ForeColor = Color.Green;
                    label3.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    enA = true;
                    enB = false;
                    break;
                case 6:     //Street B
                    label2.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    label3.ForeColor = Color.Green;
                    label4.ForeColor = Color.Green;
                    enB = true;
                    enA = false;
                    break;
                case 11:    //Crosswalk
                    label2.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    enA = false;
                    enB = false;
                    break;
            }
        }
    }
}
