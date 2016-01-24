using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHLMACR
{
    public enum EventType
    {
        [StringValue("빈 이벤트")]
        NONE,
        [StringValue("키보드")]
        KEYEVENT,
        [StringValue("마우스")]
        MOUSEEVENT
    }
}
