using System;
using Timer = System.Windows.Forms.Timer;

namespace WinFormGame.Game
{
    public class GameSilonov
    {
        public bool IsGameOver { get; set; }
        public Timer? MainTimer { get; set; }
        public Timer? UpTimer { get; set; }
        public Timer? GravityTimer { get; set; }
        public Map Map { get; set; }

        public GameSilonov(Map map)
        {
            Map = map;
        }

        public void Start()
        {

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

        }

        private void UpTimer_Tick(object sender, EventArgs e)
        {

        }

        private void GravityTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
