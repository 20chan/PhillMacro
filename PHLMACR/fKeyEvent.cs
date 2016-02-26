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
    public partial class fKeyEvent : Form
    {
        public event EventFormProc FinishedSetting;

        public fKeyEvent()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true; e.SuppressKeyPress = false;
            textBox1.Text = e.KeyCode.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private bool isCorrect()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return false;
            if ((this.rbDown.Checked | this.rbUp.Checked | this.rbClick.Checked) == false)
                return false;
            return true;
        }

        private KeyEventType GetKeyEventType()
        {
            if (this.rbDown.Checked)
                return KeyEventType.DOWN;
            if (this.rbUp.Checked)
                return KeyEventType.UP;
            if (this.rbClick.Checked)
                return KeyEventType.CLICK;
            throw new Exception("뭐지What님 사랑해요");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!isCorrect())
            {
                MessageBox.Show("잘못된 값이 있습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if(FinishedSetting != null)
            {
                KeyEvent k = new KeyEvent(0, (Keys)Enum.Parse(typeof(Keys), textBox1.Text), GetKeyEventType());
                FinishedSetting(k, true);
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
