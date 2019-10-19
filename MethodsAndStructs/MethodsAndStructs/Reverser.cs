using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class Reverser : ITransformer, IMovement
    {

        //public Reverser(string word) : base(word)
        //{
        //    Console.WriteLine("Reverser constructor");
        //}
        //public override 

        public string Word { get; set; }


        string ITransformer.Transform(string word)
        {
            var newWord = String.Empty;
            for (var i = 0; i < word.Length; i++)
            {
                int letterIndex = (word.Length - 1) - i;
                Console.WriteLine(letterIndex);
                newWord += word[letterIndex];
                Console.WriteLine(newWord);
            }
            Word = newWord;
            return Word;
        }

        public void UndoReverse()
        {

        }


        public string Transform(string word)
        {
            return "Movement transform";
        }

    }
}
