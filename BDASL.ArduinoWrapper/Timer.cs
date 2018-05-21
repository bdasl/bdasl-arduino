using System;
using BDASL.ArduinoWrapper.Interfaces;

namespace BDASL.ArduinoWrapper
{
    public class Timer : ITimer
    {
        private System.Threading.Timer _timer;

        public void Start(Action action, TimeSpan dueTime, TimeSpan period)
        {
            _timer = new System.Threading.Timer(s => action(), null, dueTime, period);
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}