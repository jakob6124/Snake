using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    public enum Direction 
    { 
        North, /* Up */
        South, /* Down */
        West,  /* Left */
        East   /* Right */
    };
    class Game
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static Direction direction { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver {get; set;}

        public Game()
        {
            Width = 16;
            Height = 16;
            Speed = 12;
            Score = 0;
            GameOver = false;
            direction = Direction.South;
        }
    }
}
