using System;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzHelperTest
    {
        [TestCase(1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void Execute_Returns_Value(int number, string expected)
        {
            var instance = FizzBuzzHelper.CreateInstance();

            var actual = instance.Execute(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]  
        public void CrateInstance_Is_Singleton()
        {
            var instance1 = FizzBuzzHelper.CreateInstance();
            var instance2 = FizzBuzzHelper.CreateInstance();

            Assert.AreEqual(instance1, instance2);
        }
    }
}
