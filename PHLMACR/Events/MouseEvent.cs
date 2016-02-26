using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PHLMACR.Events
{
    public class MouseEvent : Event
    {
        public MouseType MouseType { get; set; }
        public MouseEventType MouseEventType { get; set; }
        public Point Point { get; set; }
        public override string Description
        {
            get
            {
                return string.Format("({0}, {1}) {2}{3}", Point.X, Point.Y, StringValue.GetStringValue(MouseType), StringValue.GetStringValue(MouseEventType));
            }
        }

        public MouseEvent(uint elapsed, Point point, MouseType mType, MouseEventType eType) : base(EventType.MOUSEEVENT, elapsed)
        {
            this.Point = point;
            this.MouseType = mType;
            this.MouseEventType = eType;
        }

        public override void Play()
        {
            MouseHook.MakeMouseEvent(this.MouseEventType, this.MouseType, Point);
        }
    }

    public enum MouseType
    {
        [StringValue("좌")]
        LEFT,
        [StringValue("휠")]
        WHEEL,
        [StringValue("우")]
        RIGHT
    }
    public enum MouseEventType
    {
        [StringValue("무브")]
        MOVE,
        [StringValue("다운")]
        DOWN,
        [StringValue("업")]
        UP,
        [StringValue("클릭")]
        CLICK,
        [StringValue("다운스크롤")]
        SCROLLDOWN,
        [StringValue("업스크롤")]
        SCROLLUP
    }
}
