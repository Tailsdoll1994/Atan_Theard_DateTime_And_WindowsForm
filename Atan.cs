using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Atan
{
    public partial class Atan : Form
    {
        public Atan()
        {
            InitializeComponent();
        }
        private void Time_Button_Click(object sender, EventArgs e)
        {
            if (Button_LogicThread.Checked)
            {
                textBox1.Text = TimeThread(Convert.ToUInt64(textBox2.Text));
            }
            else if (Button_Logic.Checked)
            {
                textBox1.Text = Time(Convert.ToUInt64(textBox2.Text));
            }
            else
            {
                MessageBox.Show("Взаимоисключающая ошибка");
            }
        }
        private void Formula(UInt64 num)
        {
            Random rndx = new Random();
            Random rndy = new Random();

            double radians;
            double angle;

            for (UInt32 i = 0; i < num; i++)
            {
                radians = Math.Atan2(rndx.NextDouble(), rndy.NextDouble());
                angle = radians * (180 / Math.PI);
            }
        }
        private string TimeThread(UInt64 num)
        {
            List<Thread> t = new List<Thread>();
            var start = DateTime.Now;
            for (int j = 0; j < Convert.ToInt32(TheardWrite.Text); j++)
            {
                t.Add(new Thread(() =>
                {
                    Formula(num / Convert.ToUInt64(TheardWrite.Text));
                }));
                t[j].Start();
            }
            for (int j = 0; j < Convert.ToInt32(TheardWrite.Text); j++)
            {
                t[j].Join();
            }
            return (DateTime.Now - start).ToString();
        }
        private string Time(UInt64 num)
        {
            Random rndx = new Random();
            Random rndy = new Random();

            double radians;
            double angle;
            var start = DateTime.Now;
            for (UInt64 i = 0; i < num; i++)
            {
                radians = Math.Atan2(rndx.NextDouble(), rndy.NextDouble());
                angle = radians * (180 / Math.PI);
            }
            var timeEnd = DateTime.Now - start;

            return timeEnd.ToString();
        }

        private void Button_LogicThread_CheckedChanged(object sender, EventArgs e)
        {
            if (Button_LogicThread.Checked.Equals(true))
            {
                TheardWrite.Enabled = true;
                TheardMessage.Enabled = true;
            }
            else
            {
                TheardWrite.Enabled = false;
                TheardMessage.Enabled = false;
            }
        }
    }
}