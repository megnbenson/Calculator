using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class StaticCalculatorTest
    {
        //Add
        [TestCase(1,8,9)]
        public void AddTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(8, 1, 7)]
        public void SubtractTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(8, 2, 4)]
        public void DivideTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 2, 4)]
        public void MultiplyTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 2, 0)]
        public void ModulusTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Modulus(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }





    }
}