using System;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzHelperTest
    {
        [TestCase(1,"1")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void Execute_Return_Value(int number, string expected)
        {
            var instance = FizzBuzzHelper.CreateInstance();

            var actual = instance.Execute(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
