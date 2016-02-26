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
    public partial class fMacro : Form
    {
        Macro macro = new Macro();
        public fMacro(Macro m)
        {
            InitializeComponent();
            this.macro = m;

            foreach(Event e in m.Events)
            {
                ListViewItem i = new ListViewItem(e.ElapsedTick.ToString());
                i.SubItems.Add(StringValue.GetStringValue(e.EventType));
                i.SubItems.Add(e.Description);
                this.lvEvents.Items.Add(i);
            }
        }

        private void RestoreListView()
        {
            this.lvEvents.Items.Clear();
            foreach(Event e in macro.Events)
            {
                ListViewItem i = new ListViewItem(e.ElapsedTick.ToString());
                i.SubItems.Add(StringValue.GetStringValue(e.EventType));
                i.SubItems.Add(e.Description);
                this.lvEvents.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmsEventType.Show(Cursor.Position);
        }

        private void 키보드이벤트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKeyEvent key = new fKeyEvent();
            key.FinishedSetting += (ev, b) =>
            {
                if (!b) return;
                macro.Events.Add(ev); //이거 프로퍼티나 메서드로 변경하자
                RestoreListView();
            };
            key.ShowDialog();
        }

        private void 마우스이벤트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMouseEvent mouse = new fMouseEvent();
            mouse.FinishedSetting += (ev, b) =>
            {
                if (!b) return;
                macro.Events.Add(ev);
                RestoreListView();
            };
            mouse.ShowDialog();
        }

        public void Play()
        {
            macro.Play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }
    }
}
