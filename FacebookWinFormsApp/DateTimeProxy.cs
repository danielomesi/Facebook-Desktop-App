using System;

namespace BasicFacebookFeatures
{
    public class DateTimeProxy
    {
        private double m_ElapsedSeconds;
        private DateTime m_LastLoginDateTime;

        public double ElapsedSeconds
        {
            get
            {
                return m_ElapsedSeconds;
            }
            set
            {
                m_ElapsedSeconds = value;
            }
        }

        public DateTime LastLoginDateTime
        {
            get
            { 
                return m_LastLoginDateTime;
            }
            set 
            {
                m_LastLoginDateTime = value;
            }
        }

        public void UpdateBeforeLeaving(SessionTimer i_SessionTimer, DateTime i_LastLoginDateTime)
        {
            double elapsedSeconds = i_SessionTimer.GetSeconds();
            m_ElapsedSeconds = elapsedSeconds + m_ElapsedSeconds;
            m_LastLoginDateTime = i_LastLoginDateTime;
        }
    }
}