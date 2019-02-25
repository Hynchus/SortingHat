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
    public partial class SeatingPlanGrid : UserControl
    {
        public int GridHSliderValue { get => GridHSlider.Value; set => this.GridHSlider.Value = value; }
        public int GridHSliderMax { get => GridHSlider.Maximum; set => this.GridHSlider.Maximum = value; }   
        public int GridHSliderMin { get => GridHSlider.Minimum; set => this.GridHSlider.Minimum = value; }
        public int GridVSliderValue { get => GridVSlider.Value; set => this.GridVSlider.Value = value; }
        public int GridVSliderMax { get => GridVSlider.Maximum; set => this.GridVSlider.Maximum = value; }
        public int GridVSliderMin { get => GridVSlider.Minimum; set => this.GridVSlider.Minimum = value; }

        private List<List<ClassroomSpotControl>> spots = new List<List<ClassroomSpotControl>>();
        private int currentRowCount = 0;
        private int currentColumnCount = 0;


        private int targetRowCount()
        {
            return GridVSlider.Maximum - GridVSlider.Value + GridVSlider.Minimum;
        }

        private int targetColumnCount()
        {
            return GridHSlider.Maximum - GridHSlider.Value + GridHSlider.Minimum;
        }

        private void updateGrid()
        {

            /*
            if (currentColumnCount < targetColumnCount())
            {
                foreach (List<ClassroomSpotControl> row in spots)
                {
                    while (row.Count < targetColumnCount())
                    {
                        row.Add(new ClassroomSpotControl());
                    }
                }
            }
            if (currentColumnCount > targetColumnCount())
            {
                
            }
            */
        }

        public SeatingPlanGrid()
        {
            InitializeComponent();
        }

        private void GridHSlider_Scroll(object sender, EventArgs e)
        {
            ClassroomSpotPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            while (ClassroomSpotPanel.Controls.Count < (ClassroomSpotPanel.RowCount * targetColumnCount()))
            {
                ClassroomSpotControl new_spot = new ClassroomSpotControl();
                new_spot.Dock = DockStyle.Fill;
                ClassroomSpotPanel.Controls.Add(new_spot);
            }
            while (ClassroomSpotPanel.ColumnCount > targetColumnCount())
            {
                ClassroomSpotPanel.ColumnStyles.RemoveAt(ClassroomSpotPanel.ColumnCount - 1);
            }
        }

        private void GridVSlider_Scroll(object sender, EventArgs e)
        {

        }

    }
}
