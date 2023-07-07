using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naje_Joffer
{
    public partial class ucUserMaintenance : UserControl
    {
        

        public ucUserMaintenance()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Equals("") || tbEmailAddress.Text.Equals("") || tbLastName.Text.Equals("") || tbPassword.Text.Equals("") || tbUsername.Text.Equals(""))
            {
                MessageBox.Show("Please complete the requirements.");
            }
            else
            {
                ListViewItem list = new ListViewItem(tbFirstName.Text);
                list.SubItems.Add(tbLastName.Text);
                list.SubItems.Add(tbEmailAddress.Text);
                list.SubItems.Add(tbUsername.Text);
                list.SubItems.Add(tbPassword.Text);
                userList.Items.Add(list);

            }
        }

        private void userList_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
                tbFirstName.Text = userList.SelectedItems[0].SubItems[0].Text;
                tbLastName.Text = userList.SelectedItems[0].SubItems[1].Text;
                tbEmailAddress.Text = userList.SelectedItems[0].SubItems[2].Text;
                tbUsername.Text = userList.SelectedItems[0].SubItems[3].Text;
                tbPassword.Text = userList.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
                userList.SelectedItems[0].SubItems[0].Text = tbFirstName.Text;
                userList.SelectedItems[0].SubItems[1].Text = tbLastName.Text;
                userList.SelectedItems[0].SubItems[2].Text = tbEmailAddress.Text;
                userList.SelectedItems[0].SubItems[3].Text = tbUsername.Text;
                userList.SelectedItems[0].SubItems[4].Text = tbPassword.Text;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
                userList.Items.Remove(userList.SelectedItems[0]);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmailAddress.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}


