using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int second = dateTime.Second;
            int minute = dateTime.Minute;

            textBox1.Text = second.ToString() + " seconds  " + minute.ToString() + " minutes";

            //textBox1.Text = dateTime.ToString("ss,mm");

        }

        private void button2_Click(object sender, EventArgs e)
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

    }
}
