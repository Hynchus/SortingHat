using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class ChecklistForm : Form
    {
        public List<string> checkedItems;

        private void validateChecklist()
        {
            int checkedItemCount = 0;
            foreach (CheckBox item in ChecklistPanel.Controls)
            {
                if (item.Checked)
                {
                    checkedItemCount++;
                }
            }
            Okbtn.Enabled = (checkedItemCount > 0);
        }

        private void itemCheckChanged(object sender, EventArgs e)
        {
            validateChecklist();
        }

        private void loadChecklist(List<string> items)
        {
            ChecklistPanel.Controls.Clear();
            foreach (string item in items)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                checkBox.CheckedChanged += itemCheckChanged;
                ChecklistPanel.Controls.Add(checkBox);
            }
        }

        public ChecklistForm(List<string> checklistItems, string info = "")
        {
            InitializeComponent();
            loadChecklist(checklistItems);
            this.Infolbl.Text = info;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            checkedItems = new List<string>();
            foreach (Control checkbox in ChecklistPanel.Controls)
            {
                if (((CheckBox)checkbox).Checked)
                {
                    checkedItems.Add(checkbox.Text);
                }
            }
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
