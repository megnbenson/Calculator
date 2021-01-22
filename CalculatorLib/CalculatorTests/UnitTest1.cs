using NUnit.Framework;
using CalculatorLib;
using Shouldly;

namespace CalculatorTests
{
    public class StaticCalculatorTest
    {
        //Add
        [TestCase(1,8,9)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, -4)]
        [TestCase(-2, 2, 0)]
        public void AddTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Add(num1, num2);
            //Assert.AreEqual(expectedResult, result);
            result.ShouldBe(expectedResult);
        }

        [TestCase(8, 1, 7)]
        [TestCase(66, 2,64)]
        [TestCase(0, 2,-2)]
        [TestCase(-2, 2,-4)]
        public void SubtractTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(8, 2, 4)]
        [TestCase(10, 5, 2)]
        public void DivideTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(10, 0)]
        public void WhenDivideByZeroThrowException(int num1, int num2)
        {
            var ex = Assert.Throws<System.DivideByZeroException>(() => StaticCalculator.Divide(num1, num2));
            Assert.AreEqual($"You cannot divide by {num2}", ex.Message, "Exception message not correct");            //Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 2, 4)]
        [TestCase(3, 7, 21)]
        public void MultiplyTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 2, 0)]
        [TestCase(6, 4, 2)]
        public void ModulusTest(int num1, int num2, int expectedResult)
        {
            var result = StaticCalculator.Modulus(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }





    }
}