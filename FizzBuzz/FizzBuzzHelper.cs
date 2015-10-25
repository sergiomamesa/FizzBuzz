using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzzHelper
    {
        private SortedList<int, IRule> Rules { get; set; }
        private static readonly Lazy<FizzBuzzHelper> instance = new Lazy<FizzBuzzHelper>(() => new FizzBuzzHelper());

        private FizzBuzzHelper()
        {
            Rules = new SortedList<int, IRule>();

            InitializeRules();
        }

        private void InitializeRules()
        {
            Rules.Add(1, new Rule((i) => (i % 3 == 0) && (i % 5 == 0), "FizzBuzz"));
            Rules.Add(2, new Rule((i) => (i % 3 == 0), "Fizz"));
            Rules.Add(3, new Rule((i) => (i % 5 == 0), "Buzz"));
        }

        public string Execute(int number)
        {
            foreach (var rule in Rules.OrderBy(i => i.Key))
            {
                if (rule.Value.MethodRule(number))
                    return rule.Value.Result;
            }

            return number.ToString();
        }

        public static FizzBuzzHelper CreateInstance()
        {
            return instance.Value;
        }

    }
}
