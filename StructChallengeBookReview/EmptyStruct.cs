﻿using System;
namespace StructChallengeBookReview
{
    struct BookReview
    {
        private string name;
        private int score;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetScore(int score)
        {
            if (score > 0 && score < 11)
            {
               this.score = score;
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
