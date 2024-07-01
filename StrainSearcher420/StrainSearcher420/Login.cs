using System.Drawing;
using System.Windows.Forms;

namespace StrainSearcher420
{

    public partial class loginForm : Form
    {
        // Moveable form properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0,0);

        //Database
        Database database = new Database();

        public loginForm()
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

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            bool loginSuccess = database.Login(username, password);

            if (loginSuccess) 
            {
                this.Hide();
            }
        }
    }
}
