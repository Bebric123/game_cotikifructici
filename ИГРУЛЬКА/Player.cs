using System;

namespace ИГРУЛЬКА
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player() { }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}