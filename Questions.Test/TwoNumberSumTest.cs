using NUnit.Framework;
using Questions;

namespace Questions.Test
{
    public class Tests
    {
        TwoNumberSum twoNumberSum;
        [SetUp]
        public void Setup()
        {
            twoNumberSum = new TwoNumberSum();
        }

        [Test]
        public void BurteForceWorks()
        {
            int[] testArray = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int testTargetSum = 10;

            int[] results = twoNumberSum.BurteForce(testArray, testTargetSum);

            int[] expected = { -1, 11 };
            Assert.That(expected, Is.EqualTo(results));
        }

        [Test]
        public void TestCase1()
        {
            int[] expected = { 4, 6 };
            int testSum = 10;

            int[] results = twoNumberSum.BurteForce(expected, testSum);

            Assert.That(expected, Is.EqualTo(results));
        }

        [Test]
        public void TestCase2()
        {
            int[] expected = { -9, 8 };
            int[] testArray = { 2, 0, 23, 8, 1, -9 };
            int testSum = -1;

            int[] results = twoNumberSum.BurteForce(testArray, testSum);

            Assert.That(expected, Is.EqualTo(results));
        }

    }
}