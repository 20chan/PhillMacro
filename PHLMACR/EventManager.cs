using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHLMACR.Events;

namespace PHLMACR
{
    public class EventManager
    {
        private List<Event> Events = new List<Event>();
        private bool isRecording = false;
        private uint elapsed = 0;
        private Timer timer = new Timer();

        public EventManager()
        {
            KeyboardHook.KeyEvented += KeyboardHook_KeyEvented;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed++;
        }

        private void KeyboardHook_KeyEvented(Keys key, KeyEventType type)
        {
            if(isRecording)
            {
                KeyEvent eve = new KeyEvent(elapsed, key, type);
                AddEvent(eve);
            }
        }

        public void AddEvent(Event event1)
        {
            Events.Add(event1);
        }

        public void StartRecord()
        {
            KeyboardHook.HookStart();
            isRecording = true;
            timer.Start();
        }

        public void EndRecord()
        {
            KeyboardHook.HookEnd();
            isRecording = false;
            timer.Stop();
        }
    }
}
