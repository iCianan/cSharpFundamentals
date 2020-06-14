using NUnit.Framework;
using Questions;
using System;

namespace Questions.Test
{
    [TestFixture]
    public class TwoNumberSumTests
    {
        [Test]
        public void BurteForceWorks()
        {
            int[] testArray = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int testTargetSum = 10;

            int[] results = TwoNumberSum.BurteForce(testArray, testTargetSum);

            int[] expected = { -1, 11 };
            Assert.That(expected, Is.EqualTo(results));
        }

        [Test]
        public void TestCase1()
        {
            int[] expected = { 4, 6 };
            int testSum = 10;

            int[] results = TwoNumberSum.BurteForce(expected, testSum);

            Assert.That(expected, Is.EqualTo(results));
        }

        [Test]
        public void TestCase2()
        {
            int[] expected = { -1, 11 };
            int[] testArray = { 3,5,-4,8,11,1,-1,6};
            int testSum = 10;

            int[] results = TwoNumberSum.TwoNumberSum2(testArray, testSum);
        //    Array.Sort(results);
            Assert.That(expected, Is.EqualTo(results));
        }

    }
}