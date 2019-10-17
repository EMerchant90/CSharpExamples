﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class UpperCaseReverser : Reverser
    {
        public override string Transform(string word)
        {
            var newWord = base.Transform(word);
            return newWord.ToUpper();
        }
    }
}