using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    //constructor challenge
    //score struct
    //two properties
    //current score int
    //high score as int
    //two constructors
    //one to set current and high score
    //other set current and high score to same


    struct Score
    {
        public int CurrentScore { get; set; }
        public int HighScore { get; set; }

        public Score(int currentScore, int highScore)
        {
            CurrentScore = currentScore;
            HighScore = highScore;
        }

        public Score(int score) : this(score, score)
        {

        }
    }
}
