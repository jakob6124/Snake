using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Highscore
    {
        public static int highestScore { get; set; }

        public Highscore()
        {
            highestScore = 0;
        }
    }
}
