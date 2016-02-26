using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHLMACR.Events;

namespace PHLMACR
{
    public partial class fMouseEvent : Form
    {
        public event EventFormProc FinishedSetting;

        public fMouseEvent()
        {
            InitializeComponent();
            KeyboardHook.KeyEvented += (b, d) =>
            {
                if(b== Keys.F2 && d == KeyEventType.DOWN)
                {
                    this.tbX.Text = Cursor.Position.X.ToString();
                    this.tbY.Text = Cursor.Position.Y.ToString();
                }
            };
        }

        private bool isCorrect()
        {
            if (string.IsNullOrWhiteSpace(tbX.Text) || string.IsNullOrWhiteSpace(tbY.Text))
                return false;
            if ((rbLeft.Checked | rbRight.Checked | rbWheel.Checked) != true)
                return false;
            if ((rbDown.Checked | rbUp.Checked | rbClick.Checked | rbScrollDown.Checked | rbScrollUp.Checked | rbMove.Checked) != true)
                return false;
            return true;
        }

        private void cursPos_Tick(object sender, EventArgs e)
        {
            this.lbMousePos.Text = string.Format("현재 마우스 좌표 X : {0:0000} Y : {1:0000}", Cursor.Position.X, Cursor.Position.Y);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private Point GetPoint()
        {
            return new Point(int.Parse(tbX.Text), int.Parse(tbY.Text));
        }

        private MouseType GetMouseType()
        {
            if (rbLeft.Checked)
                return MouseType.LEFT;
            if (rbRight.Checked)
                return MouseType.RIGHT;
            if (rbWheel.Checked)
                return MouseType.WHEEL;
            throw new Exception("동혀니오빠 사랑해요!!");
        }

        private MouseEventType GetMouseEventType()
        {
            if (rbDown.Checked)
                return MouseEventType.DOWN;
            if (rbUp.Checked)
                return MouseEventType.UP;
            if (rbClick.Checked)
                return MouseEventType.CLICK;
            if (rbScrollDown.Checked)
                return MouseEventType.SCROLLDOWN;
            if (rbScrollUp.Checked)
                return MouseEventType.SCROLLUP;
            if (rbMove.Checked)
                return MouseEventType.MOVE;
            throw new Exception("동혀니오빠 혼또니 사랑해요!!");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!isCorrect())
            {
                MessageBox.Show("잘못된 값이 있습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if(FinishedSetting != null)
            {
                MouseEvent me = new MouseEvent(0, GetPoint(), GetMouseType(), GetMouseEventType());
                FinishedSetting(me, true);
                FinishedSetting = null;
                this.Dispose();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            FinishedSetting = null;
            this.Dispose();
        }
    }
}
