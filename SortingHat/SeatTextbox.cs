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
    public partial class SeatTextbox : Label
    {
        bool currentlyDragging = false;
        private Student occupant;
        private ToolTip NameTooltip;
        private IContainer components;
        private Action invokeOccupantChanged;

        public Student Occupant 
        {
            get => occupant;
            set 
            {
                if (occupant == value) { return; }
                occupant = value;
                if (occupant != null)
                {
                    this.Text = occupant.Name.Split(' ')[0];
                    if (NameTooltip is null)
                    {
                        NameTooltip = new ToolTip();
                        NameTooltip.InitialDelay = 50;
                        NameTooltip.ReshowDelay = 10;
                        NameTooltip.UseAnimation = false;
                        NameTooltip.UseFading = false;
                    }
                    this.NameTooltip.SetToolTip(this, occupant.Name);
                }
                this.Visible = (occupant != null);
                invokeOccupantChanged?.Invoke();
            }
        }

        public void setOccupantChangedInvoker(Action occupantChangedInvoker)
        {
            invokeOccupantChanged = occupantChangedInvoker;
        }

        public SeatTextbox(Action occupantChangedInvoker = null)
        {
            this.MouseDown += OnMouseDown;
            this.DragEnter += OnDragEnter;
            this.DragDrop += OnDragDrop;
            setOccupantChangedInvoker(occupantChangedInvoker);
        }

        public void OnMouseDown(object sender, MouseEventArgs e) 
        {
            if (Occupant is null) { return; }
            this.currentlyDragging = true;
            List<Student> draggedStudents = new List<Student>();
            draggedStudents.Add(Occupant);
            DragDropEffects dragResult = DoDragDrop(draggedStudents, DragDropEffects.Move);
            if (dragResult == DragDropEffects.All)
            {
                Occupant = null;
            }
            this.currentlyDragging = false;
        }

        public void OnDragEnter(object sender, DragEventArgs e)
        {
            if (this.currentlyDragging) { return; }
            if (Occupant != null) { return; }
            if (!e.Data.GetDataPresent(typeof(List<Student>))) { return; }
            e.Effect = DragDropEffects.All;
        }

        public void OnDragDrop(object sender, DragEventArgs e)
        {
            if (this.currentlyDragging) { return; }
            if (Occupant != null) { return; }
            if (!e.Data.GetDataPresent(typeof(List<Student>))) { return; }
            Occupant = ((List<Student>)e.Data.GetData(typeof(List<Student>)))[0];
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // NameTooltip
            // 
            this.NameTooltip.AutoPopDelay = 30000;
            this.NameTooltip.InitialDelay = 50;
            this.NameTooltip.ReshowDelay = 10;
            this.NameTooltip.UseAnimation = false;
            this.NameTooltip.UseFading = false;
            this.ResumeLayout(false);

        }
    }
}
