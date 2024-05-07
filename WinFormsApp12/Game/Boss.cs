using System;

namespace WinFormGame.Game
{
    public class Boss : Npc
    {
        private int _health;
        public int Health { 
            get 
            {
                return _health;
            } 
            set 
            {
                AttackSpeed += _health - value;
                MoveSpeed += _health - value;
                _health = value;
            } 
        }
        public int AttackSpeed { get; set; }
        public int MoveSpeed { get; set; }

        public void Attack()
        {

        }
    }
}
