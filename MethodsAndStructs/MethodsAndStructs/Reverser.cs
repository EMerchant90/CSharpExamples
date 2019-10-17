using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class Reverser : WordTransformer
    {
        public override string Transform(string word)
        {
            var newWord = String.Empty;
            for (var i = 0; i < word.Length; i++)
            {
                int letterIndex = (word.Length - 1) - i;
                Console.WriteLine(letterIndex);
                newWord += word[letterIndex];
                Console.WriteLine(newWord);
            }
            return newWord;
        }
    }
}
