using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class SessionTimer
    {
        public const int k_Interval = 1000;
        public Stopwatch m_Stopwatch { get; set; }
        public Timer m_timer { get; set; }

        public SessionTimer()
        {
            m_Stopwatch = new Stopwatch();
            m_Stopwatch.Start();
            m_timer = new Timer();
            m_timer.Interval = k_Interval; 
        }

        public void Start(List<EventHandler> i_ListToDoOnTick)
        {
            foreach(EventHandler func in i_ListToDoOnTick)
            {
                m_timer.Tick += func;
            }
            
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