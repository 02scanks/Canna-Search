using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace StrainSearcher420
{

    public partial class Main : Form
    {
        // Moveable form properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0,0);

        public Main()
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

        private void showHybridsButton_Click(object sender, System.EventArgs e)
        {
            Hybrid hybridForm = new Hybrid();
            hybridForm.Show();
        }

        private void showSativasButton_Click(object sender, System.EventArgs e)
        {
            Sativa sativaForm = new Sativa();
            sativaForm.Show();
        }

        private void showIndicaButton_Click(object sender, System.EventArgs e)
        {
            Indica indicaForm = new Indica();   
            indicaForm.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
