using System;

namespace BDASL.ArduinoWrapper.Interfaces
{
    public interface ITimer : IDisposable
    {
        void Start(Action action, TimeSpan dueTime, TimeSpan period);
    }
}