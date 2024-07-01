using System.Drawing;
using System.Windows.Forms;

namespace StrainSearcher420
{

    public partial class AddStrain : Form
    {
        // Moveable form properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0,0);

        //Database
        Database database = new Database();

        string filePath = string.Empty;

        public AddStrain()
        {
            InitializeComponent();
        }

        #region Movable Form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) 
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        #endregion

        private void addStrainButton_Click(object sender, System.EventArgs e)
        {
            // assign value to variables
            string name = strainNameInputBox.Text;
            string effect = effectInputBox.Text;
            string negatives = negativesInputBox.Text;
            string THC = thcInputBox.Text;
            string CBD = cbdInputBox.Text;
            string taste = tasteInputBox.Text;
            string rating = ratingInputBox.Text;

            // make sure all fields are filled out
            if (strainNameInputBox.Text == string.Empty ||
                effectInputBox.Text == string.Empty ||
                negativesInputBox.Text == string.Empty ||
                tasteInputBox.Text == string.Empty ||
                thcInputBox.Text == string.Empty ||
                cbdInputBox.Text == string.Empty ||
                strainComboBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Out All Fields");
            }
            else 
            {

                //assign data to relative table
                if (strainComboBox.Text == "Hybrid")
                {
                    database.AddToHybridDB(name, THC, CBD, rating, filePath, name + ".img", effect, negatives, taste);
                }
                else if (strainComboBox.Text == "Indica")
                {
                    database.AddToIndicaDB(name, THC, CBD, rating, filePath, name + ".img", effect, negatives, taste);
                }
                else if (strainComboBox.Text == "Sativa")
                {
                    database.AddToSativaDB(name, THC, CBD, rating, filePath, name + ".img", effect, negatives, taste);
                }
            }

        }

        private void addImageButton_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                filePath = openFileDialog1.FileName;
                strainImageDisplay.Image = Image.FromFile(filePath);
            }
        }
    }
}
