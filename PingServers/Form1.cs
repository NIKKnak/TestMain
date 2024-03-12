using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PingServers
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 5000; // 5 seconds
            timer.Tick += Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Controls.Clear();

            var list = new List<string>
            {
                "vk.com",
                "youtube.com",
                "ya.ru",
                "fb.com",
            };

            var pingResults = list.Select(x =>
            {
                var ping = new Ping();
                var reply = ping.Send(x);
                return new { Host = x, Time = reply.RoundtripTime, Success = reply.Status == IPStatus.Success };
            });

            foreach (var result in pingResults)
            {
                var label = new Label();
                label.AutoSize = true;
                label.Text = $"{result.Host} - {result.Time} мс";
                label.Location = new Point(10, label1.Controls.Count * 20);

                if (result.Success)
                {
                    label.ForeColor = Color.Green;
                }
                else
                {
                    label.ForeColor = Color.Red;
                }

                label1.Controls.Add(label);
            }
        }
    }
}
