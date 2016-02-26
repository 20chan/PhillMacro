using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHLMACR;
using PHLMACR.Events;

namespace PhillMacro
{
    public partial class CSGOBHOP : Form
    {
        bool isStart = true;

        public CSGOBHOP()
        {
            InitializeComponent();
            KeyboardHook.KeyEvented += KeyboardHook_KeyEvented;
            KeyboardHook.HookStart();
        }
        ~CSGOBHOP() { KeyboardHook.HookEnd(); }

        bool isPressingAlt = false;
        private void KeyboardHook_KeyEvented(Keys key, KeyEventType type)
        {
            if (key == Keys.F9 && Control.ModifierKeys != Keys.Shift && type == KeyEventType.DOWN) // F9를 눌렀을 때
            {
                if (this.Visible)
                    Hide();
            }
            else if (key == Keys.F9 && Control.ModifierKeys == Keys.Shift && type == KeyEventType.DOWN) // Shift F9를 눌렀을 때
            {
                if (!this.Visible)
                {
                    Show();
                }
            }

            if (!isStart) return;
            if (key == Keys.Space && type == KeyEventType.DOWN)
                isPressingAlt = true;
            if (key == Keys.Space && type == KeyEventType.UP)
                isPressingAlt = false;
            if (isPressingAlt)
            {
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
                MouseHook.MakeMouseEvent(MouseEventType.SCROLLDOWN, MouseType.WHEEL, new Point());
            }
        }
    }
}
