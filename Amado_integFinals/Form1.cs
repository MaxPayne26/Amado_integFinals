using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naje_Joffer

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim().Equals(""))
            {
                tbUsername.Focus();
                MessageBox.Show("Please enter user name");
            }
            else if (tbPassword.Text.Trim().Equals(""))
            {
                tbPassword.Focus();
                MessageBox.Show("Please enter password");
            }
            else
            {
                frm2 frm = new frm2();
                frm.Show();
                this.Hide();
            }
        }
    }
}
