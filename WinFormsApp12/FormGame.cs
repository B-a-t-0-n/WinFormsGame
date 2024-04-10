namespace WinFormGame
{
    public partial class FormGame : Form
    {
        private bool _left, _right, _up, _down;
        private int speed = 10;
        private int speedGravity = 5;
        private int jumpHeight = 10;

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
            if (playerP.Location.Y + speedGravity <= playerZone.Height - playerP.Height && CheckMovement(playerP, 0, speedGravity))
            {
                playerP.Location = new Point(playerP.Location.X, playerP.Location.Y + speedGravity);
            }
            else
            {
                GravitationTimer.Enabled = false;
            }
        }

        private void UpTimer_Tick(object sender, EventArgs e)
        {
            if (playerP.Location.Y - speed >= playerZone.Height - (playerZone.Height - playerP.Location.Y) - playerP.Height * jumpHeight)
            {
                playerP.Location = new Point(playerP.Location.X, playerP.Location.Y - speed);
                jumpHeight--;
            }
            else
            {
                UpTimer.Enabled = false;
                GravitationTimer.Enabled = true;
                jumpHeight = 10;
                
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            if(_left && playerP.Left > 0 && CheckMovement(playerP, speed * (-1), 0))
            {
                playerP.Location = new Point(playerP.Location.X - speed, playerP.Location.Y);
            }
            if (_right && playerP.Right <= playerZone.Width - playerP.Width / 6 && CheckMovement(playerP, speed, 0))
            {
                playerP.Location = new Point(playerP.Location.X + speed, playerP.Location.Y);
            }
            if (_up)
            {
                if (!GravitationTimer.Enabled)
                {
                    UpTimer.Enabled = true;

                }
            }  
        }

        private bool CheckMovement(Control player ,int x, int y)
        {
            //копия персонажа для проверки на возможность передвижения
            var testP = new Control();

            playerZone.Controls.Add(testP);
            testP.Visible = false;
            testP.Location = player.Location;
            testP.Size = player.Size;


            testP.Location = new Point(testP.Location.X + x, testP.Location.Y + y);

            foreach (Control item in playerZone.Controls)
            {
                if (item is Panel)
                {
                    if (testP.Bounds.IntersectsWith(item.Bounds))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
