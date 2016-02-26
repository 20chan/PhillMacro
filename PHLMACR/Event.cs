using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHLMACR
{
    public delegate void EventFormProc(Event e, bool isClosing);
    public abstract class Event
    {
        public EventType EventType { get; set; } = EventType.NONE;
        public uint ElapsedTick { get; set; } = 0;
        public abstract string Description { get; }

        public Event(EventType type, uint elapsed)
        {
            this.EventType = type;
            this.ElapsedTick = elapsed;
        }

        public abstract void Play();
    }
}
