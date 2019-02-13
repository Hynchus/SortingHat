using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class GroupingDisplay : UserControl
    {
        private Grouping grouping = null;

        public GroupingDisplay()
        {
            InitializeComponent();
        }

        public GroupingDisplay(Grouping grouping = null)
        {
            InitializeComponent();
            this.grouping = grouping;
        }

        private void displayGroups()
        {
            GroupingLayoutPanel.Controls.Clear();
            if (grouping == null) { return; }
            foreach (Group group in grouping.Groups)
            {
                GroupDisplay groupDisplay = new GroupDisplay();
                groupDisplay.displayGroup(group);
                GroupingLayoutPanel.Controls.Add(groupDisplay);
            }
        }

        public void clearDisplay()
        {
            GroupingLayoutPanel.Controls.Clear();
        }

        public void displayGrouping(Grouping grouping)
        {
            this.grouping = grouping;
            displayGroups();
        }

        private void GroupingDisplay_Load(object sender, EventArgs e)
        {
            displayGroups();
        }

        public List<Group> getCurrentGroups()
        {
            List<Group> groups = new List<Group>();
            foreach (GroupDisplay groupDisplay in GroupingLayoutPanel.Controls)
            {
                groups.Add(groupDisplay.getCurrentGroup());
            }
            return groups;
        }

        public bool groupChangesExist()
        {
            foreach (GroupDisplay groupDisplay in GroupingLayoutPanel.Controls)
            {
                if (groupDisplay.getChanges().Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
