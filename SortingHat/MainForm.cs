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
    public partial class MainForm : Form
    {
        private void loadSettings()
        {
            this.Location = Properties.Settings.Default.MainFormLocation;
            this.Size = Properties.Settings.Default.MainFormSize;
            this.BackColor = Properties.Settings.Default.ColourTheme;
            Model.setCurrentClass(Properties.Settings.Default.CurrentClass);
        }

        private void saveSettings()
        {
            Properties.Settings.Default.MainFormLocation = this.Location;
            Properties.Settings.Default.MainFormSize = this.Size;
            if (Model.currentClass != null)
            {
                Properties.Settings.Default.CurrentClass = Model.currentClass.Name;
            }
            else
            {
                Properties.Settings.Default.CurrentClass = "";
            }
            Properties.Settings.Default.Save();
        }

        private void loadClassNames()
        {
            //clearClassButtons();
            foreach (string className in Model.getClassNames())
            {
                addClassButton(className);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Model.subscribeToCurrentClassChanged(loadCurrentClass);
            Model.subscribeToCurrentGroupingChanged(loadCurrentGrouping);
            loadClassNames();
            loadSettings();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(ClassNameDisplay.Text, ClassNameDisplay.Font);
            ClassNameDisplay.Size = size;
        }

        private void unloadClass()
        {
            ClassNameDisplay.Visible = false;
            ClassNameDisplay.Enabled = false;
            ClassNameDisplay.Text = "";
            unloadGroupings();
            foreach (ToolStripItem button in classToolStripMenuItem.DropDownItems)
            {
                if (button.GetType() == typeof(ToolStripSeparator)) { continue; }
                ((ToolStripMenuItem)button).Checked = false;
            }
        }

        private void unloadGrouping()
        {
            GroupingDisplaybtn.Visible = false;
            GroupingDisplaybtn.Enabled = false;
            GroupingDisplaybtn.Text = "";
            foreach (ToolStripItem button in groupingToolStripMenuItem.DropDownItems)
            {
                if (button.GetType() == typeof(ToolStripSeparator)) { continue; }
                ((ToolStripMenuItem)button).Checked = false;
            }
            GroupingDisplayPanel.clearDisplay();
        }

        private void unloadGroupings()
        {
            groupingToolStripMenuItem.Enabled = false;
            groupingToolStripMenuItem.Visible = false;
            while (groupingToolStripMenuItem.DropDownItems.Count > 2)
            {
                groupingToolStripMenuItem.DropDownItems.RemoveAt(2);
            }
            unloadGrouping();
        }

        private void loadGroupings()
        {
            unloadGroupings();
            foreach (Grouping grouping in Model.currentClass.Groupings)
            {
                addGroupingButton(grouping.Name);
            }
            loadCurrentGrouping(null, null);
            groupingToolStripMenuItem.Enabled = true;
            groupingToolStripMenuItem.Visible = true;
        }

        private void loadCurrentGrouping(object sender, EventArgs e)
        {
            if (Model.currentClass == null || string.IsNullOrEmpty(Model.currentClass.CurrentGroupingName))
            {
                unloadGrouping();
                return;
            }
            GroupingDisplaybtn.Text = Model.currentClass.CurrentGroupingName;
            GroupingDisplaybtn.Visible = true;
            GroupingDisplaybtn.Enabled = true;

            foreach (ToolStripItem button in groupingToolStripMenuItem.DropDownItems)
            {
                if (button.GetType() == typeof(ToolStripSeparator))
                {
                    continue;
                }
                if (button.Text == Model.currentClass.CurrentGroupingName)
                {
                    ((ToolStripMenuItem)button).Checked = true;
                }
                else
                {
                    ((ToolStripMenuItem)button).Checked = false;
                }
            }
            GroupingDisplayPanel.displayGrouping(Model.currentClass.getCurrentGrouping());
        }

        private void loadCurrentClass(object sender, EventArgs e)
        {
            if (Model.currentClass == null)
            {
                unloadClass();
                return;
            }
            string currentClassName = Model.currentClass.Name;
            ClassNameDisplay.Text = currentClassName;
            ClassNameDisplay.Enabled = true;
            ClassNameDisplay.Visible = true;
            foreach (ToolStripItem button in classToolStripMenuItem.DropDownItems)
            {
                if (button.GetType() == typeof(ToolStripSeparator))
                {
                    continue;
                }
                if (button.Text == currentClassName)
                {
                    ((ToolStripMenuItem)button).Checked = true;
                }
                else
                {
                    ((ToolStripMenuItem)button).Checked = false;
                }
            }
            loadGroupings();
        }

        private void classButtonClicked(object sender, EventArgs e)
        {
            Model.setCurrentClass(((ToolStripMenuItem)sender).Text);
        }

        private void clearClassButtons()
        {
            foreach (ToolStripItem item in classToolStripMenuItem.DropDownItems)
            {
                if ((string)item.Tag != "Structural")
                {
                    classToolStripMenuItem.DropDownItems.Remove(item);
                }
            }
        }

        private void addClassButton(string className)
        {
            ToolStripMenuItem button = new ToolStripMenuItem(className);
            button.Click += classButtonClicked;
            classToolStripMenuItem.DropDownItems.Add(button);
        }

        private void NewClassbtn_Click(object sender, EventArgs e)
        {
            ClassEditForm classForm = new ClassEditForm();
            classForm.ShowDialog();
            if (classForm.DialogResult == DialogResult.OK)
            {
                Model.createClass(classForm.className, classForm.studentNames);
                addClassButton(classForm.className);
                Model.setCurrentClass(classForm.className);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Model.saveCurrentClass();
            saveSettings();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string originalClassName = Model.currentClass.Name;
            ClassEditForm classForm = new ClassEditForm(Model.currentClass.Name);
            classForm.ShowDialog();
            if (classForm.DialogResult == DialogResult.OK)
            {
                foreach (ToolStripItem button in classToolStripMenuItem.DropDownItems)
                {
                    if (button.Text == originalClassName)
                    {
                        button.Text = classForm.className;
                        break;
                    }
                }
                Model.updateCurrentClass(classForm.className, classForm.studentNames);
            }
        }

        private void ClassDeletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete '" + Model.currentClass.Name + "'?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ToolStripItem classButton = null;
                foreach (ToolStripItem item in classToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == Model.currentClass.Name)
                    {
                        classButton = item;
                        break;
                    }
                }
                classToolStripMenuItem.DropDownItems.Remove(classButton);
                Model.deleteCurrentClass();
            }
        }

        private void groupingButtonClicked(object sender, EventArgs e)
        {
            Model.currentClass.CurrentGroupingName = ((ToolStripMenuItem)sender).Text;
        }

        private void addGroupingButton(string groupingName)
        {
            ToolStripMenuItem button = new ToolStripMenuItem(groupingName);
            button.Click += groupingButtonClicked;
            groupingToolStripMenuItem.DropDownItems.Add(button);
        }

        private void NewGroupingbtn_Click(object sender, EventArgs e)
        {
            GroupingEditForm groupingForm = new GroupingEditForm();
            groupingForm.ShowDialog();
            if (groupingForm.DialogResult == DialogResult.OK)
            {
                Model.createGrouping(Model.currentClass.Name, groupingForm.groupingName, groupingForm.groupCount);
                Model.currentClass.CurrentGroupingName = groupingForm.groupingName;
            }
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string originalGroupingName = Model.currentClass.CurrentGroupingName;
            GroupingEditForm groupingForm = new GroupingEditForm(Model.currentClass.CurrentGroupingName);
            groupingForm.ShowDialog();
            if (groupingForm.DialogResult == DialogResult.OK)
            {
                foreach (ToolStripItem button in groupingToolStripMenuItem.DropDownItems)
                {
                    if (button.Text == originalGroupingName)
                    {
                        button.Text = groupingForm.groupingName;
                        break;
                    }
                }
                Model.currentClass.updateGrouping(originalGroupingName, groupingForm.groupingName, groupingForm.groupCount);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the '" + Model.currentClass.CurrentGroupingName + "' grouping?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ToolStripItem groupingButton = null;
                foreach (ToolStripItem item in groupingToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == Model.currentClass.CurrentGroupingName)
                    {
                        groupingButton = item;
                        break;
                    }
                }
                groupingToolStripMenuItem.DropDownItems.Remove(groupingButton);
                Model.currentClass.removeGrouping(Model.currentClass.CurrentGroupingName);
            }
        }

        private void randomizeGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to shuffle the groups?", "Shuffle", MessageBoxButtons.OKCancel) != DialogResult.OK) { return; }
            Model.currentClass.shuffleGrouping(Model.currentClass.CurrentGroupingName);
        }

        private void WordExportbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = FileHandler.getSharingFolder();
            saveFileDialog.DefaultExt = ".docx";
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
            FileHandler.exportGroupingToWord(saveFileDialog.FileName, Model.currentClass.getGrouping(Model.currentClass.CurrentGroupingName), Model.currentClass.Name);
            FileHandler.setSharingFolder(saveFileDialog.FileName);
        }

        private void importClass(object sender, EventArgs e)
        {
            Model.saveCurrentClass();
            OpenFileDialog importFileDialog = new OpenFileDialog();
            importFileDialog.Title = "Class Import";
            importFileDialog.InitialDirectory = FileHandler.getSharingFolder();
            importFileDialog.Multiselect = true;
            importFileDialog.DefaultExt = FileHandler.CLASS_FILE_EXTENSION;
            importFileDialog.Filter = "Sorting Hat Class (*" + FileHandler.CLASS_FILE_EXTENSION + ")|*" + FileHandler.CLASS_FILE_EXTENSION;
            if (importFileDialog.ShowDialog() != DialogResult.OK) { return; }
            FileHandler.setSharingFolder(importFileDialog.FileName);

            List<string> importedFiles = importFileDialog.FileNames.ToList();
            foreach (string fileName in importFileDialog.FileNames)
            {
                if (!FileHandler.importClassFile(fileName))
                {
                    if (MessageBox.Show("The class '" + FileHandler.getClassName(fileName) + "' already exists. Do you want to overwrite it?", "Overwrite Permission", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FileHandler.importClassFile(fileName, true);
                    }
                    else
                    {
                        importedFiles.Remove(fileName);
                    }
                }
            }
            loadClassNames();
            Model.reloadCurrentClass();
            if (importedFiles.Count > 0)
            {
                string importedItems = "";
                foreach (string item in importedFiles)
                {
                    importedItems = Environment.NewLine + " - " + FileHandler.getClassName(item);
                }
                MessageBox.Show("The following classes were imported:" + importedItems, "Import successful", MessageBoxButtons.OK);
            }
        }

        private void exportClass(object sender, EventArgs e)
        {
            Model.saveCurrentClass();
            ChecklistForm checklist = new ChecklistForm(FileHandler.getSavedClassNames(), "Checkmark the classes you want exported.");
            if (checklist.ShowDialog() != DialogResult.OK) { return; }
            if (checklist.checkedItems.Count <= 0) { return; }

            FolderBrowserDialog exportFolderDialog = new FolderBrowserDialog();
            exportFolderDialog.SelectedPath = FileHandler.getSharingFolder();
            if (exportFolderDialog.ShowDialog() != DialogResult.OK) { return; }
            FileHandler.setSharingFolder(exportFolderDialog.SelectedPath);

            List<string> exportedClasses = checklist.checkedItems;
            foreach (string className in checklist.checkedItems)
            {
                if (!FileHandler.exportClassFile(className, exportFolderDialog.SelectedPath))
                {
                    if (MessageBox.Show("A copy of '" + className + "' already exists there. Do you want to overwrite it?", "Overwrite Permission", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FileHandler.exportClassFile(className, exportFolderDialog.SelectedPath, true);
                    }
                    else
                    {
                        exportedClasses.Remove(className);
                    }
                }
            }
            if (exportedClasses.Count > 0)
            {
                string exportedItems = "";
                foreach (string item in exportedClasses)
                {
                    exportedItems = Environment.NewLine + " - " + item + FileHandler.CLASS_FILE_EXTENSION;
                }
                MessageBox.Show("The following files can be found at '" + exportFolderDialog.SelectedPath + "':" + exportedItems, "Export successful", MessageBoxButtons.OK);
            }
        }

        private bool checkForGroupChanges()
        {
            return GroupingDisplayPanel.groupChangesExist();
        }

        private void constraintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstraintsEditForm constraintsForm = new ConstraintsEditForm(Model.currentClass.Students, Model.currentClass.Constraints);
            constraintsForm.ShowDialog();
            if (constraintsForm.DialogResult == DialogResult.OK)
            {
                Model.currentClass.updateConstraints(constraintsForm.Constraints);
                Model.saveCurrentClass();
            }
        }
    }
}
