using System;

namespace WinFormGame.Game
{
    public class Npc
    {
        public string? Name { get; set; }
        public Bitmap? Background { get; set; }
        public bool IsDead { get; set; }
        public IEnumerable<string>? Dialog { get; set; }
    }
}
