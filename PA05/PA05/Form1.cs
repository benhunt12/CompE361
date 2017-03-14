using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PA05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            timeLabel.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void setAlarm_Click(object sender, EventArgs e)
        {
            alarmLabel.Text = hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00");
            timer2.Start();
            this.hoursSet.Enabled = false;
            this.minutesSet.Enabled = false;
            this.secondsSet.Enabled = false;
        }

        private void Play()
        {
            string soundfile = @"C:\Users\benja\Desktop\Alien_AlarmDrum-KevanGC-893953959.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

        private void Stop()
        {
            string soundfile = @"C:\Users\benja\Desktop\Alien_AlarmDrum-KevanGC-893953959.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLabel.Text == alarmLabel.Text)
            {
                Play();
            }
        }

        private void stopAlarm_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Stop();
            this.hoursSet.Enabled = true;
            this.minutesSet.Enabled = true;
            this.secondsSet.Enabled = true;
        }

        private void snooze_Click(object sender, EventArgs e)
        {
            Class1 MOTO = new Class1();
            //20 second snooze
            
            int min, sec, h;
            h = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;

            sec += MOTO.snooze;
            if (sec > 59)
            {
                min++;
                sec = sec - 60;
                if (min > 59)
                {
                    h++;
                    min = min - 60;
                    if (h > 23)
                    {
                        h = 1;
                    }
                }       
            }

            alarmLabel.Text = h.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
            Stop();

        }

        private void setSnooze_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
