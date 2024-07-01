using System.Drawing;
using System.Windows.Forms;
using Panel = ReaLTaiizor.Controls.Panel;

namespace StrainSearcher420
{

    public partial class Indica : Form
    {
        // Moveable form properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0,0);

        Database database = new Database();

        int indexMultiplier = 0;
        

        public Indica()
        {
            InitializeComponent();

            database.PopulateIndicas(indicaPanel, indexMultiplier);
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

        private void addIndicaButton_Click(object sender, System.EventArgs e)
        {
            AddStrain addStrain = new AddStrain();
            addStrain.Show();
            this.Hide();

            indexMultiplier++;
        }
    }
}
