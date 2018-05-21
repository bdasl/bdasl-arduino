using System;
using System.Collections.Generic;
using BDASL.ArduinoWrapper.Interfaces;

namespace BDASL.ArduinoWrapper
{
    public abstract class MultiPinComponentcs : Component
    {
        public MultiPinComponentcs(IArduino board, IEnumerable<int> pins, ITimer timer = null)
            : base(board, timer)
        {
            Pins = pins;
        }

        public IEnumerable<int> Pins { get; set; }

        protected void SetPinMode(PinMode mode)
        {
            foreach (var pin in Pins)
            {
                Board.PinMode(pin, mode);
            }
        }
    }
}