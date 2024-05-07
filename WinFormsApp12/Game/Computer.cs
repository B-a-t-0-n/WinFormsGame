using System;

namespace WinFormGame.Game
{
    public class Computer : Block
    {
        public int Damage { get; set; }
        public BorderDamage Damages { get; set; }
    }

    public struct BorderDamage
    {
        public int damageTop;
        public int damageBottom;
        public int damageLeft;
        public int damageRight;
    }
}
