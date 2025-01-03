using System;
using System.Collections.ObjectModel;
using Timer = System.Windows.Forms.Timer;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a time interval & activity");
                return;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int second = dateTime.Second;
            int minute = dateTime.Minute;

            textBox1.Text = second.ToString() + " seconds  " + minute.ToString() + " minutes";

            //textBox1.Text = dateTime.ToString("ss,mm");

        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] chose= new string[comboBox2.Items.Count];
            int i = 0;
            foreach(String item in comboBox2.Items)
            {
                chose[i] = item;
                i++;
            }

            for (int u = 0; u < chose.Length; u++)
            {
                if (comboBox2.SelectedText == chose[u])
                {
                    break;
                }
                else
                {
                    comboBox2.Items.Add(comboBox2.SelectedText);    
                }
            }

        }

    }
}
