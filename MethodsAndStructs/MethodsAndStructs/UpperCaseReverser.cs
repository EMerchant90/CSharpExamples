using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class UpperCaseReverser : ITransformer
    {
        public string Word { get; set; }

        public string Transform(string word)
        {
            var reverser = new Reverser();
            Word = reverser.Transform(word);
            Word = Word.ToUpper();
            return Word;
        }



        //public UpperCaseReverser(string word) : base(word)
        //{
        //    Console.WriteLine("UpperCaseReverser constructor");
        //}

        //public override string Transform()
        //{
        //    Word = base.Transform().ToUpper();
        //    return Word;
        //}
    }
}
