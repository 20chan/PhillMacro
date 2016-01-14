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

namespace PhillMacro
{
    public partial class Form1 : Form
    {
        List<KeyEvent> KeyEvents = new List<KeyEvent>();
        bool isStart = false;
        uint elapsed = 0;
        public Form1()
        {
            InitializeComponent();
            KeyboardHook.KeyEvented += KeyboardHook_KeyEvented;
        }

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

            KeyEvents.Add(new KeyEvent(elapsed, key, type));

            if (type == KeyEventType.DOWN) this.tbText.AppendText(key.ToString() + " ");
        }

        private void Start()
        {
            if (isStart) return;
            KeyboardHook.HookStart();
            isStart = true;
            timer1.Start();
        }

        private void Stop()
        {
            if (!isStart) return;
            KeyboardHook.HookEnd();
            isStart = false;
            timer1.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbText.Clear();
        }

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isStart)
            {
                elapsed++;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isStart) return;
            
            foreach(KeyEvent k in KeyEvents)
            {
                KeyboardHook.MakeKeyEvent(k.Key, k.KeyEventType);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}