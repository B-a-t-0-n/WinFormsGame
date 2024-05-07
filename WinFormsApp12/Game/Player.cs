using System;

namespace WinFormGame.Game
{
    public class Player
    {
        public int CountWires { get; set; }
        public ControlKeys Keys { get; set; }
        public int Health { get; set; }
        public Bitmap? Background { get; set; }
        public int MoveSpeed { get; set; }
        public int JumpHeight { get; set; }

        public Player(int health)
        {

        }
    }

    public struct ControlKeys
    {
        public Keys up;
        public Keys down;
        public Keys left;
        public Keys right;
        public Keys interaction;
    }
}
