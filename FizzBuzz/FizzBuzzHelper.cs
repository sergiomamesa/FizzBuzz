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
        private SortedList<int, Rule> Rules { get; set; }

        private FizzBuzzHelper()
        {
            Rules = new SortedList<int, Rule>();
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
            var instance = new FizzBuzzHelper();

            instance.Rules.Add(1, new Rule(Rule1, "FizzBuzz"));
            instance.Rules.Add(2, new Rule(Rule2, "Fizz"));
            instance.Rules.Add(3, new Rule(Rule3, "Buzz"));

            return instance;
        }

        private static bool Rule1(int number)
        {
            return (number % 3 == 0) && (number % 5 == 0);
        }

        private static bool Rule2(int number)
        {
            return (number % 3 == 0);
        }

        private static bool Rule3(int number)
        {
            return (number % 5 == 0);
        }

    }
}
