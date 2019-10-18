using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class StringUtilities
    {
        public static int ReverseCount { get; private set; }
        //public int WordCount { get; set; }

        public static string Reverse(string word)
        {
            StringUtilities.ReverseCount += 1;
            var newWord = String.Empty;
            for (var i = 0; i < word.Length; i++)
            {
                int letterIndex = (word.Length - 1) - i;
                Console.WriteLine(letterIndex);
                newWord += word[letterIndex];
                Console.WriteLine(newWord);
            }
            //WordCount += newWord.Length;
            return newWord;
        }
    }
}
