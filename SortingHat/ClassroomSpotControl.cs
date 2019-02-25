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
    public partial class ClassroomSpotControl : UserControl
    {
        private bool seat = false;
        private Student occupant = null;

        private bool Seat 
        {
            get { return this.seat; }
            set 
            {
                this.seat = value;
                if (this.seat)
                {
                    showSeat();
                }
                else
                {
                    hideSeat();
                }
            }
        }

        private void showSeat()
        {
            this.BackgroundImage = BackgroundImages.Images[1];
            OccupantNamelbl.Visible = true;
        }

        private void hideSeat()
        {
            this.BackgroundImage = BackgroundImages.Images[0];
            OccupantNamelbl.Visible = false;
        }

        public ClassroomSpotControl(ClassroomSpot classroomSpot = null)
        {
            InitializeComponent();
            if (classroomSpot != null)
            {
                UpdateSpot(classroomSpot.Seat, classroomSpot.Occupant);
            }
        }

        public void UpdateSpot(bool seat = false, Student occupant = null)
        {
            this.seat = seat;
            this.occupant = occupant;
            if (occupant != null)
            {
                Seat = true;
            }
            else
            {
                Seat = seat;
            }
        }

        private void ClassroomSpotControl_Click(object sender, EventArgs e)
        {
            if (this.occupant != null) { return; }
            Seat = !Seat;
        }

        public ClassroomSpot GetClassroomSpot()
        {
            return new ClassroomSpot(Seat, this.occupant);
        }
    }
}
