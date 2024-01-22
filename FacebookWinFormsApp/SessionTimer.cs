using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class SessionTimer
    {
        public const int k_Interval = 1000;
        public Stopwatch m_Stopwatch;
        public Timer m_timer;

        public SessionTimer(EventHandler i_DoOnTick)
        {
            m_Stopwatch = new Stopwatch();
            m_Stopwatch.Start();
            m_timer = new Timer();
            m_timer.Interval = k_Interval;
            m_timer.Tick += i_DoOnTick;
            m_timer.Start();
        }

        public string GetCurrentTimeAsString()
        {
            string hours = $"{m_Stopwatch.Elapsed.Hours:D2}";
            string minutes = $"{m_Stopwatch.Elapsed.Minutes:D2}";
            string seconds = $"{m_Stopwatch.Elapsed.Seconds:D2}";
            string timeAsString = string.Format("{0}:{1}:{2}", hours, minutes, seconds);

            return timeAsString;
        }
    }
}