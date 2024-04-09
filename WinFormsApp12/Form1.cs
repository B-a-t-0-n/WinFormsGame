namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            timer1.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (!timer1.Enabled)
                    {
                        timer2.Enabled = true;
                        
                    }
                        
                    break;
                case Keys.A:
                    panelP.Location = panelP.Location.X - speed <= 0 ? new Point(panelP.Location.X, panelP.Location.Y) : new Point(panelP.Location.X - speed, panelP.Location.Y);
                    break;
                case Keys.S:
                    panelP.Location = new Point(panelP.Location.X, panelP.Location.Y - panelP.Width);
                    break;
                case Keys.D:
                    panelP.Location = panelP.Location.X + speed + panelP.Width + speed >= this.Width ? new Point(panelP.Location.X, panelP.Location.Y) : new Point(panelP.Location.X + speed, panelP.Location.Y); ;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 5;

            if (panelP.Location.Y + speed <= panel2.Height - panelP.Height)
            {
                panelP.Location = new Point(panelP.Location.X, panelP.Location.Y + speed);
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int speed = 10;

            if (panelP.Location.Y - speed >= panel2.Height - panelP.Height - panelP.Height - panelP.Height)
            {
                panelP.Location = new Point(panelP.Location.X, panelP.Location.Y - speed);
            }
            else
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }
    }
}
