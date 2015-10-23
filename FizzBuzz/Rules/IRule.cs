using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules
{
    internal interface IRule
    {
        string Result { get; set; }

        Func<int, bool> MethodRule { get; set; }
    }
}
