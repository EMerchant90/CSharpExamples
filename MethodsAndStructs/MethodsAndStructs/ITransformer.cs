using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    interface ITransformer
    {
        string Word { get; set; }
        string Transform(string word);
    }
}
