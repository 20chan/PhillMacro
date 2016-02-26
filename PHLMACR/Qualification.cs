using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHLMACR
{
    public abstract class Qualification
    {
        public QualificationType QualType;
        public abstract bool isSatisfied();
    }

    public enum QualificationType
    {
        DATETIME, // 일정 시각이 되면
        STOPWATCH, // 일정 시간 뒤에
        LOOP, // 일정 시간을 간격으로 반복
        KEY // 키보드 이벤트가 일어나면
    }
}
