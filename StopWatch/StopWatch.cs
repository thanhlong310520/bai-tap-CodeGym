using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        DateTime startTime;
        DateTime endTime;
        public DateTime GetStartTime()
        {
            return startTime;
        }
        public DateTime GetEndTime()
        {
            return endTime;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public TimeSpan GetElapsedTime()
        {
            return endTime.Subtract(startTime);
        }


        

    }
}
