﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHLMACR
{
    public class KeyEvent : Event
    {
        public KeyEventType KeyEventType { get; set; }
        public Keys Key { get; set; }

        public KeyEvent(uint elapsed, Keys key, KeyEventType type) : base(EventType.KEYEVENT, elapsed)
        {
            this.Key = key;
            this.KeyEventType = type;
        }

        public override void Play()
        {
            KeyboardHook.MakeKeyEvent(Key, KeyEventType);
        }
    }

    
}
