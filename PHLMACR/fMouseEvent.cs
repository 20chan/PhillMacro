using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHLMACR
{
    public partial class fMouseEvent : Form
    {
        public fMouseEvent()
        {
            InitializeComponent();
            KeyboardHook.KeyEvented += (b, d) =>
            {
                if(b== Keys.F2 && d == KeyEventType.DOWN)
                {
                    this.textBox1.Text = Cursor.Position.X.ToString();
                    this.textBox2.Text = Cursor.Position.Y.ToString();
                }
            };
        }

        private void cursPos_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("현재 마우스 좌표 X : {0:0000} Y : {1:0000}", Cursor.Position.X, Cursor.Position.Y);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
