using Core;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RecursionTests
    {
        Recursion recursion;

        [SetUp]
        public void Setup()
        {
            recursion = new Recursion();
        }

        [Test]
        public void ShowerWorks()
        {
            string actual = recursion.TakeShower();
            string expected = "Showering";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetNthFib_Should_ReturnExpectedValue_When_PositiveNumberPassed()
        {
            //arrange
            var number = 5;

            //act
            var result = recursion.GetNthFib(number);

            //assert

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void CountEvenPassed_Should_ReturnZero_When_EmptyArrayPassed()
        {
            //arrange
            var number = new int[] { };

            //act
            var result = recursion.countEvenPassed(number);

            //assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CountEvenPassed_Should_ReturnExpectedValue_When_ArrayOfIntegersPassed()
        {
            //arrange
            var number = new int[] { 5,6,12 };

            //act
            var result = recursion.countEvenPassed(number);

            //assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void IterativeArraySum_Should_ReturnExpectedValue_When_ArrayOfIntegersPassed()
        {
            //arrange
            var number = new int[] { 5, 6, 12 };

            //act
            var result = recursion.IterativeArraySum(number);

            //assert
            Assert.That(result, Is.EqualTo(23));
        }
        [Test]
        public void ArraySumDelgate_Should_ReturnExpectedValue_When_ArrayOfIntegersPassed()
        {
            //arrange
            var number = new int[] { 5, 6, 12 };

            //act
            var result = recursion.ArraySumDelgate(number);

            //assert
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void ArraySumRecursive_Should_ReturnExpectedValue_When_ArrayOfIntegersPassed()
        {
            //arrange
            var number = new int[] { 5, 6, 12 };

            //act
            var result = recursion.ArraySumRecursive(number);

            //assert
            Assert.That(result, Is.EqualTo(23));
        }
    }
}