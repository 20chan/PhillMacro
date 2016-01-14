using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace PHLMACR
{
    public enum KeyEventType
    {
        DOWN, UP
    }
    public class KeyboardHook
    {
        public delegate void KeyboardProc(Keys key, KeyEventType type);
        public static event KeyboardProc KeyEvented;
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("User32.dll")]
        private static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYDOWN = 0x104;
        private const int WM_SYSKEYUP = 0x105;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    Keys key = (Keys)vkCode;
                    /*
                    bool Alt = false, Control = false, Shift = false;

                    Alt = (System.Windows.Forms.Control.ModifierKeys & Keys.Alt) != 0;
                    Control = (System.Windows.Forms.Control.ModifierKeys & Keys.Control) != 0;
                    Shift = (System.Windows.Forms.Control.ModifierKeys & Keys.Shift) != 0;

                    if (Alt) key |= Keys.Alt;
                    if (Control) key |= Keys.Control;
                    if (Shift) key |= Keys.Shift;
                    */
                    if (KeyEvented != null)
                    {
                        KeyEvented(key, KeyEventType.DOWN);
                    }
                }
                else if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    Keys key = (Keys)vkCode;
                    /*
                    bool Alt = false, Control = false, Shift = false;

                    Alt = (System.Windows.Forms.Control.ModifierKeys & Keys.Alt) != 0;
                    Control = (System.Windows.Forms.Control.ModifierKeys & Keys.Control) != 0;
                    Shift = (System.Windows.Forms.Control.ModifierKeys & Keys.Shift) != 0;

                    if (Alt) key |= Keys.Alt;
                    if (Control) key |= Keys.Control;
                    if (Shift) key |= Keys.Shift;
                    */
                    if (KeyEvented != null)
                    {
                        KeyEvented(key, KeyEventType.UP);
                    }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        public static void HookStart()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        public static void HookEnd()
        {
            UnhookWindowsHookEx(_hookID);
        }

        public static void MakeKeyEvent(Keys key, KeyEventType type)
        {
            switch(type)
            {
                case KeyEventType.DOWN:
                    keybd_event((byte)key, 0x00, 0x00, 0);
                    break;
                case KeyEventType.UP:
                    keybd_event((byte)key, 0x00, 0x02, 0);
                    break;
            }
        }
    }

    public class MouseHook
    {
    }
}