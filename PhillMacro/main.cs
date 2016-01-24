using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhillMacro
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            Form f = new Form1()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Size = new Size(356, 318),
                MinimumSize = new Size(356,318),
                Visible = true
            };
            this.contextMenuStrip1.Items.Add(new ToolStripControlHost(f));
            this.contextMenuStrip1.Items[0].Size = new Size(356, 318);
        }
    }
}
