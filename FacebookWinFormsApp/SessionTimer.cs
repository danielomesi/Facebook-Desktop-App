using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class SessionTimer
    {
        private const int k_Interval = 1000;
        private Stopwatch m_Stopwatch;
        private Timer m_timer;

        public Stopwatch Stopwatch
        {
            get { return m_Stopwatch; }
            set { m_Stopwatch = value; }
        }

        public Timer Timer
        {
            get { return m_timer; }
            set { m_timer = value; }
        }

        public SessionTimer()
        {
            m_Stopwatch = new Stopwatch();
            m_Stopwatch.Start();
            m_timer = new Timer();
            m_timer.Interval = k_Interval; 
        }

        public void Start(EventHandler i_ToDoOnTick)
        {
            m_timer.Tick += i_ToDoOnTick;
            m_timer.Start();
        }

        public string ConvertTimeSpanToString(TimeSpan i_TimeSpan)
        {
            string hours = $"{i_TimeSpan.Hours:D2}";
            string minutes = $"{i_TimeSpan.Minutes:D2}";
            string seconds = $"{i_TimeSpan.Seconds:D2}";
            string timeAsString = string.Format("{0}:{1}:{2}", hours, minutes, seconds);

            return timeAsString;
        }

        public double GetSeconds()
        {
            return m_Stopwatch.Elapsed.TotalSeconds;
        }

        public void Stop()
        {
            m_Stopwatch.Stop();
            m_timer.Stop();
        }
    }
}