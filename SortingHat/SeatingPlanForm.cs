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
    public partial class SeatingPlanForm : Form
    {

        private void loadSettings()
        {
            if (Properties.Settings.Default.SeatingPlanFormSize != new Size(-1, -1))
            {
                this.Location = Properties.Settings.Default.SeatingPlanFormLocation;
                this.Size = Properties.Settings.Default.SeatingPlanFormSize;
            }
            this.BackColor = Properties.Settings.Default.ColourTheme;
            this.WindowState = (FormWindowState)Properties.Settings.Default.SeatingPlanFormState;
        }

        private void saveSettings()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.SeatingPlanFormLocation = this.Location;
                Properties.Settings.Default.SeatingPlanFormSize = this.Size;
            }
            Properties.Settings.Default.SeatingPlanFormState = (int)this.WindowState;
            Properties.Settings.Default.Save();
        }

        private int sliderVtoRowCount()
        {
            return GridVSlider.Maximum - GridVSlider.Value + GridVSlider.Minimum;
        }

        private int rowCounttoSliderV()
        {
            return GridVSlider.Minimum + GridVSlider.Maximum - ClassroomSpotTable.RowCount;
        }

        private int sliderHtoColumnCount()
        {
            return GridHSlider.Maximum - GridHSlider.Value + GridHSlider.Minimum;
        }

        private int columnCounttoSliderH()
        {
            return GridHSlider.Minimum + GridHSlider.Maximum - ClassroomSpotTable.ColumnCount;
        }

        private void resizeClassroomSpotTable(int columnCount, int rowCount, bool fill = false)
        {
            // Handle shrinking (stopping at seats)

            int oldColumnCount = ClassroomSpotTable.ColumnCount;
            int oldRowCount = ClassroomSpotTable.RowCount;
            ClassroomSpotTable.ColumnCount = columnCount;
            ClassroomSpotTable.RowCount = rowCount;

            float columnPercentage = ClassroomSpotTable.ColumnCount / 100.0f;
            for (int x = oldColumnCount; x < ClassroomSpotTable.ColumnCount; x++)
            {
                ClassroomSpotTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));
            }
            for (int x = 0; x < oldColumnCount; x++)
            {
                ClassroomSpotTable.ColumnStyles[x].Width = columnPercentage;
            }
            float rowPercentage = ClassroomSpotTable.RowCount / 100.0f;
            for (int y = oldRowCount; y < ClassroomSpotTable.RowCount; y++)
            {
                ClassroomSpotTable.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercentage));
            }
            for (int y = 0; y < oldRowCount; y++)
            {
                ClassroomSpotTable.RowStyles[y].Height = rowPercentage;
            }
            if (fill)
            {
                int difference = (ClassroomSpotTable.ColumnCount * ClassroomSpotTable.RowCount) - (oldColumnCount * oldRowCount);
                if (difference > 0)
                {
                    for (int i = 0; i < difference; i++)
                    {
                        ClassroomSpotTable.Controls.Add(new ClassroomSpotControl() { Dock = DockStyle.Fill });
                    }
                }
            }
            GridHSlider.Value = columnCounttoSliderH();
            GridVSlider.Value = rowCounttoSliderV();
        }

        public void LoadSeatingPlan(Tuple<List<ClassroomSpot>, Size> seatingPlan)
        {
            ClassroomSpotTable.Controls.Clear();
            ClassroomSpotTable.ColumnStyles.Clear();
            ClassroomSpotTable.RowStyles.Clear();
            ClassroomSpotTable.ColumnCount = 0;
            ClassroomSpotTable.RowCount = 0;
            if (seatingPlan is null)
            {
                resizeClassroomSpotTable(sliderHtoColumnCount(), sliderVtoRowCount(), true);
            }
            else
            {
                resizeClassroomSpotTable(seatingPlan.Item2.Width, seatingPlan.Item2.Height);

                foreach (ClassroomSpot spot in seatingPlan.Item1)
                {
                    ClassroomSpotTable.Controls.Add(new ClassroomSpotControl(spot));
                }
            }

            
        }

        public SeatingPlanForm(List<Student> students, Tuple<List<ClassroomSpot>, Size> seatingPlan)
        {
            InitializeComponent();
            StudentListbox.updateStudentList(students);
            LoadSeatingPlan(seatingPlan);
        }

        private void SeatingPlanForm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void GridVSlider_Scroll(object sender, EventArgs e)
        {
            resizeClassroomSpotTable(sliderHtoColumnCount(), sliderVtoRowCount(), true);
        }

        private void GridHSlider_Scroll(object sender, EventArgs e)
        {
            resizeClassroomSpotTable(sliderHtoColumnCount(), sliderVtoRowCount(), true);
        }
    }
}
