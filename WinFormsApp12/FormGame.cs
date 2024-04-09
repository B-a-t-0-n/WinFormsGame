namespace WinFormGame
{
    public partial class FormGame : Form
    {
        private bool _left, _right, _up, _down;
        private int speed = 10;
        private int speedGravity = 5;

        public FormGame()
        {
            InitializeComponent();
            KeyPreview = true;
            GravitationTimer.Enabled = true;
            MainTimer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _up = true;
                    break;
                case Keys.D:
                    _right = true;
                    break;
                case Keys.S:
                    _down = true;
                    break;
                case Keys.A:
                    _left = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _up = false;
                    break;
                case Keys.D:
                    _right = false;
                    break;
                case Keys.S:
                    _down = false;
                    break;
                case Keys.A:
                    _left = false;
                    break;
            }
        }

        private void GravitationTimer_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y + speedGravity <= playerZone.Height - player.Height)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + speedGravity);
            }
            else
            {
                GravitationTimer.Enabled = false;
            }
        }

        private void UpTimer_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y - speed >= playerZone.Height - player.Height * 3)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - speed);
            }
            else
            {
                UpTimer.Enabled = false;
                GravitationTimer.Enabled = true;
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            if(_left && player.Left > 0)
            {
                player.Location = new Point(player.Location.X - speed, player.Location.Y);
            }
            if (_right && player.Right <= playerZone.Width)
            {
                player.Location = new Point(player.Location.X + speed, player.Location.Y);
            }
            if (_up)
            {
                if (!GravitationTimer.Enabled)
                {
                    UpTimer.Enabled = true;

                }
            }  
        }
    }
}
