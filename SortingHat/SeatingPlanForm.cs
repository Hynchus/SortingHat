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
        private bool ready = false;
        private Random random = new Random();

        private int classroomRowCount = 0;
        private int classroomColumnCount = 0;

        private Point maxIndex = Point.Empty;

        private List<ClassroomSpot> loadedSeatingPlan;

        private HashSet<ClassroomSpotControl> unoccupiedDesks = new HashSet<ClassroomSpotControl>();
        private HashSet<ClassroomSpotControl> occupiedDesks = new HashSet<ClassroomSpotControl>();


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

        private int calculateColumnCount()
        {
            return (int)Math.Ceiling((float)(ClassroomSpotsPanel.Width / (new ClassroomSpotControl()).Width)) + 1;
        }

        private int calculateRowCount()
        {
            return (int)Math.Ceiling((float)(ClassroomSpotsPanel.Height / (new ClassroomSpotControl()).Height)) + 1;
        }

        private void refreshDeskCount()
        {
            int unaccommodatedStudentCount = StudentListbox.Students.Count - unoccupiedDesks.Count;
            if (unaccommodatedStudentCount > 0)
            {
                DeskCountlbl.Text = string.Join("", "You need ", unaccommodatedStudentCount.ToString(), " more desks to accommodate all of your students.");
            }
            DeskCountlbl.Visible = (unaccommodatedStudentCount > 0);
            Seatbtn.Enabled = (unaccommodatedStudentCount <= 0) && (StudentListbox.Students.Count > 0);
            Unseatbtn.Enabled = (occupiedDesks.Count > 0);
        }

        private void updateDeskState(ClassroomSpotControl desk, bool seat, bool occupied)
        {
            if (!seat)
            {
                occupiedDesks.Remove(desk);
                unoccupiedDesks.Remove(desk);
            }
            else
            {
                if (occupied)
                {
                    unoccupiedDesks.Remove(desk);
                    occupiedDesks.Add(desk);
                }
                else
                {
                    occupiedDesks.Remove(desk);
                    unoccupiedDesks.Add(desk);
                }
            }
            refreshDeskCount();
        }

        private void seatRandomStudent()
        {
            ClassroomSpotControl[] unoccupiedDeskArray = unoccupiedDesks.ToArray();
            int deskIndex = random.Next(0, unoccupiedDeskArray.Length);
            ClassroomSpotControl desk = unoccupiedDeskArray[deskIndex];
            int studentIndex = random.Next(0, StudentListbox.Students.Count);
            desk.Occupant = StudentListbox.popStudent(studentIndex);
        }

        private void unseatRandomStudent()
        {
            if (occupiedDesks.Count <= 0) { return; }
            ClassroomSpotControl desk = occupiedDesks.First();
            StudentListbox.appendStudentList(new List<Student> { desk.Occupant });
            desk.Occupant = null;
        }

        private ClassroomSpot popSpotByLocation(List<ClassroomSpot> classroomSpots, Point targetLocation)
        {
            if (classroomSpots is null) { return null; }
            int index = 0;
            foreach (ClassroomSpot classroomSpot in classroomSpots)
            {
                if (classroomSpot.Location.Equals(targetLocation))
                {
                    break;
                }
                index++;
            }
            if (index >= classroomSpots.Count) { return null; }   // Somewhat unclear, this occurs if we didn't find target spot
            ClassroomSpot targetSpot = classroomSpots[index];
            classroomSpots.RemoveAt(index);
            return targetSpot;
        }

        private Point getClassroomSpotLocation(int x, int y)
        {
            Size classroomSpotSize = new ClassroomSpotControl().Size;
            return new Point(x * classroomSpotSize.Width, y * classroomSpotSize.Height);
        }

        private void addClassroomSpot(int x, int y, ClassroomSpot data = null)
        {
            ClassroomSpotControl newSpot = new ClassroomSpotControl();
            newSpot.subscribeToDeskChange(updateDeskState);
            newSpot.Location = getClassroomSpotLocation(x, y);
            newSpot.UpdateSpot(new Point(x, y), data?.Occupant, (data != null));
            StudentListbox.removeStudentList(new List<Student>() { data?.Occupant });
            ClassroomSpotsPanel.Controls.Add(newSpot);
        }

        private void growMaxIndex(Point newIndex)
        {
            if (newIndex.X > maxIndex.X)
            {
                maxIndex.X = newIndex.X;
            }
            if (newIndex.Y > maxIndex.Y)
            {
                maxIndex.Y = newIndex.Y;
            }
        }

        private void growMaxIndex(List<ClassroomSpot> classroomSpots)
        {
            if (classroomSpots is null) { return; }
            foreach (ClassroomSpot classroomSpot in classroomSpots)
            {
                growMaxIndex(classroomSpot.Location);
            }
        }

        private void growClassroomSpots()
        {
            growMaxIndex(loadedSeatingPlan);
            int columnCount = Math.Max(calculateColumnCount(), maxIndex.X + 1);
            int rowCount = Math.Max(calculateRowCount(), maxIndex.Y + 1);

            // Grow columns
            for (int x = classroomColumnCount; x < columnCount; x++)
            {
                for (int y = 0; y < classroomRowCount; y++)
                {
                    addClassroomSpot(x, y, popSpotByLocation(loadedSeatingPlan, new Point(x, y)));
                }
                classroomColumnCount++;
            }

            // Grow rows
            for (int y = classroomRowCount; y < rowCount; y++)
            {
                for (int x = 0; x < classroomColumnCount; x++)
                {
                    addClassroomSpot(x, y, popSpotByLocation(loadedSeatingPlan, new Point(x, y)));
                }
                classroomRowCount++;
            }
        }

        public void LoadSeatingPlan()
        {
            growClassroomSpots();
            // Grow window to make sure all desks are visible
            Point minimumSize = getClassroomSpotLocation(maxIndex.X + 1, maxIndex.Y + 1);
            int widthDifference = minimumSize.X - ClassroomSpotsPanel.Width;
            int heightDifference = minimumSize.Y - ClassroomSpotsPanel.Height;
            if (widthDifference > 0)
            {
                this.Width = this.Width + widthDifference;
            }
            if (heightDifference > 0)
            {
                this.Height = this.Height + heightDifference;
            }
            ClassroomSpotsPanel.Invalidate();
        }

        public SeatingPlanForm(List<Student> students, List<ClassroomSpot> seatingPlan)
        {
            InitializeComponent();
            StudentListbox.subscribeToStudentListChangeEvent(refreshDeskCount);
            StudentListbox.updateStudentList(students);
            loadedSeatingPlan = seatingPlan?.ToList();
        }

        private void SeatingPlanForm_Load(object sender, EventArgs e)
        {
            loadSettings();
            LoadSeatingPlan();
            ready = true;
        }

        private void ClassroomSpotsPanel_Resize(object sender, EventArgs e)
        {
            if (!ready) { return; }
            growClassroomSpots();
        }

        private void SeatingPlanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void Seatbtn_Click(object sender, EventArgs e)
        {
            while (StudentListbox.Students.Count > 0)
            {
                seatRandomStudent();
            }
        }

        private void Unseatbtn_Click(object sender, EventArgs e)
        {
            while (occupiedDesks.Count > 0)
            {
                unseatRandomStudent();
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<ClassroomSpot> GetSeatingPlan()
        {
            List<ClassroomSpot> seatingPlan = new List<ClassroomSpot>();
            foreach (ClassroomSpotControl desk in occupiedDesks)
            {
                seatingPlan.Add(new ClassroomSpot(desk.SpotLocation, desk.Occupant));
            }
            foreach (ClassroomSpotControl desk in unoccupiedDesks)
            {
                seatingPlan.Add(new ClassroomSpot(desk.SpotLocation, desk.Occupant));
            }
            return seatingPlan;
        }

        private Bitmap TakeScreenshot(Control control)
        {
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private void ExportImagebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = FileHandler.getSharingFolder();
            saveFileDialog.FileName = Model.currentClass.Name + " Seating Plan";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "PNG Image (*.png)|*.png";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
            FileHandler.setSharingFolder(saveFileDialog.FileName);
            FileHandler.saveImage(TakeScreenshot(ClassroomSpotsPanel), System.Drawing.Imaging.ImageFormat.Png, saveFileDialog.FileName, true);
        }
    }
}
