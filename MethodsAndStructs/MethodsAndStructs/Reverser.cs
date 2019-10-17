using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class Reverser : WordTransformer
    {

        public Reverser(string word) : base(word)
        {
            Console.WriteLine("Reverser constructor");
        }
        public override string Transform()
        {
            var newWord = String.Empty;
            for (var i = 0; i < Word.Length; i++)
            {
                int letterIndex = (Word.Length - 1) - i;
                Console.WriteLine(letterIndex);
                newWord += Word[letterIndex];
                Console.WriteLine(newWord);
            }
            Word = newWord;
            return newWord;
        }
    }
}
