using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PHLMACR
{
    public class MouseEvent : Event
    {
        public MouseEventType MouseEventType { get; set; }
        public Point Point { get; set; }
        public override string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MouseEvent(uint elapsed, Point point) : base(EventType.MOUSEEVENT, elapsed)
        {
            this.Point = point;
        }

        public override void Play()
        {

        }
    }

    public enum MouseEventType
    {
        DOWN, UP
    }
}
