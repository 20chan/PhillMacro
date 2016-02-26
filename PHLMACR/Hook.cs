using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using PHLMACR.Events;

namespace PHLMACR
{
    public enum KeyEventType
    {
        [StringValue("다운")]
        DOWN,
        [StringValue("업")]
        UP,
        [StringValue("클릭")]
        CLICK
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
                case KeyEventType.CLICK:
                    keybd_event((byte)key, 0x00, 0x00, 0);
                    keybd_event((byte)key, 0x00, 0x02, 0);
                    break;
            }
        }
    }

    public class MouseHook
    {
        private const uint LBDOWN = 0x00000002; // 왼쪽 마우스 버튼 눌림
        private const uint LBUP = 0x00000004; // 왼쪽 마우스 버튼 떼어짐
        private const uint RBDOWN = 0x00000008; // 오른쪽 마우스 버튼 눌림
        private const uint RBUP = 0x000000010; // 오른쪽 마우스 버튼 떼어짐
        private const uint MBDOWN = 0x00000020; // 휠 버튼 눌림
        private const uint MBUP = 0x000000040; // 휠 버튼 떼어짐
        private const uint WHEEL = 0x00000800; //휠 스크롤

        [DllImport("user32.dll")] // 입력 제어
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")] // 커서 위치 제어
        static extern int SetCursorPos(int x, int y);

        public static void MakeMouseEvent(MouseEventType metype, MouseType mtype, System.Drawing.Point p)
        {
            if(metype == MouseEventType.MOVE)
            {
                SetCursorPos(p.X, p.Y);
                return;
            }
            
            switch(mtype)
            {
                case MouseType.LEFT:
                    {
                        SetCursorPos(p.X, p.Y);
                        switch(metype)
                        {
                            case MouseEventType.DOWN:
                                mouse_event(LBDOWN, 0, 0, 0, 0);
                                break;
                            case MouseEventType.UP:
                                mouse_event(LBUP, 0, 0, 0, 0);
                                break;
                            case MouseEventType.CLICK:
                                mouse_event(LBDOWN, 0, 0, 0, 0);
                                mouse_event(LBUP, 0, 0, 0, 0);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case MouseType.RIGHT:
                    {
                        SetCursorPos(p.X, p.Y);
                        switch (metype)
                        {
                            case MouseEventType.DOWN:
                                mouse_event(RBDOWN, 0, 0, 0, 0);
                                break;
                            case MouseEventType.UP:
                                mouse_event(RBUP, 0, 0, 0, 0);
                                break;
                            case MouseEventType.CLICK:
                                mouse_event(RBDOWN, 0, 0, 0, 0);
                                mouse_event(RBUP, 0, 0, 0, 0);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case MouseType.WHEEL:
                    {
                        switch (metype)
                        {
                            case MouseEventType.DOWN:
                                SetCursorPos(p.X, p.Y);
                                mouse_event(MBDOWN, 0, 0, 0, 0);
                                break;
                            case MouseEventType.UP:
                                SetCursorPos(p.X, p.Y);
                                mouse_event(MBUP, 0, 0, 0, 0);
                                break;
                            case MouseEventType.CLICK:
                                SetCursorPos(p.X, p.Y);
                                mouse_event(MBDOWN, 0, 0, 0, 0);
                                mouse_event(MBUP, 0, 0, 0, 0);
                                break;
                            case MouseEventType.SCROLLDOWN:
                                mouse_event(WHEEL, 0, 0, -10, 0);
                                break;
                            case MouseEventType.SCROLLUP:
                                mouse_event(WHEEL, 0, 0, 10, 0);
                                break;
                        }
                        break;
                    }
            }
        }
    }
}