using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class WordTransformer
    {

        public string Word { get; set; }

        public WordTransformer(string word)
        {
            Console.WriteLine("Wordtransformer constructor");
            Word = word;
        }

        public virtual string Transform()
        {
            return Word;
        }
    }
}
