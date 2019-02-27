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
        private Point spotLocation;

        public bool Seat 
        {
            get { return this.seat; }
            set 
            {
                if (this.seat == value) { return; }
                this.seat = value;
                toggleShowSeat(this.seat);
                invokeDeskStateChanged();
            }
        }

        public Point SpotLocation { get => spotLocation; set => spotLocation = value; }
        public Student Occupant { get => Occupantlbl.Occupant; set => Occupantlbl.Occupant = value; }

        public delegate void DeskChange(ClassroomSpotControl desk, bool seat, bool occupied);
        private event DeskChange DeskStateChanged;

        public void invokeDeskStateChanged()
        {
            DeskStateChanged?.Invoke(this, Seat, Occupant != null);
        }

        public void subscribeToDeskChange(DeskChange handler)
        {
            DeskStateChanged += handler;
        }

        public void unsubscribeFromDeskChange(DeskChange handler)
        {
            DeskStateChanged -= handler;
        }

        private void toggleShowSeat(bool showSeat)
        {
            this.AllowDrop = showSeat;
            if (showSeat)
            {
                this.BackgroundImage = BackgroundImages.Images[1];
            }
            else
            {
                this.BackgroundImage = BackgroundImages.Images[0];
            }
        }

        public void UpdateSpot(Point location, Student occupant = null, bool overrideShowTable = false)
        {
            SpotLocation = location;
            Occupant = occupant;
            if (overrideShowTable || Occupant != null)
            {
                Seat = true;
            }
            else
            {
                Seat = false;
            }
        }

        public ClassroomSpotControl()
        {
            InitializeComponent();
            Occupantlbl.setOccupantChangedInvoker(invokeDeskStateChanged);
        }

        private void ClassroomSpotControl_Click(object sender, EventArgs e)
        {
            if (Occupant != null) { return; }
            Seat = !Seat;
        }

        public ClassroomSpot GetClassroomSpot()
        {
            return new ClassroomSpot(SpotLocation, Occupant);
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (!Seat) { return; }
            Occupantlbl.OnDragEnter(sender, e);
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if (!Seat) { return; }
            Occupantlbl.OnDragDrop(sender, e);
        }
    }
}
