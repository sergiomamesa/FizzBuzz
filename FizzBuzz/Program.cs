using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = FizzBuzzHelper.CreateInstance();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Execute(i));
            }

            Console.ReadKey();
        }
    }
}
