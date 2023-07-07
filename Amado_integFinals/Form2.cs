using System;
using System.Windows.Forms;

namespace Naje_Joffer
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucUserMaintenance uc = new ucUserMaintenance();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
    }
}
