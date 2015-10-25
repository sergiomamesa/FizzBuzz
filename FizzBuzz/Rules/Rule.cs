using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules
{
    internal class Rule
    {
        public string Result { get; private set; }
        public Func<int, bool> MethodRule { get; private set; }

        public Rule(Func<int, bool> methodRule, string result)
        {
            MethodRule = methodRule;
            Result = result;
        }
    }
}
