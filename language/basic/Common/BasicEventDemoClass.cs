using System;

namespace basic.Common
{
    internal class BasicEventDemoClass
    {
        public event EventHandler Event;

        public void TriggerEvent()
        {
            OnTriggerEvent();
        }

        private void OnTriggerEvent()
        {
            EventHandler handler = Event;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}