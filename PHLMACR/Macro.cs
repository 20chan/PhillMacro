using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHLMACR
{
    public class Macro
    {
        public List<Event> Events = new List<Event>();

        public void Play()
        {
            foreach(Event e in Events)
            {
                e.Play();
                System.Threading.Thread.Sleep(10);
            }
        }

        public void Save()
        {
            throw new NotImplementedException(); // 이거 구현 해야
        }
    }
}
