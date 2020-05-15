using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    public class ValidateSubsequenceTests
    {
        [Test]
        public void TestCase1()
        {
            //arrange
            var sampleArray = new int[]{ 5, 1, 22, 25, 6, -1, 8, 10 };
            var sampleSequence = new int[] { 1, 22, 25, 8, 10};

            //act
            var result = Arrays.ValidateSubsequence(sampleArray, sampleSequence);

            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestCase2()
        {
            //arrange
            var sampleArray = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sampleSequence = new List<int>() { 22,25,6};

            //act
            var result = Arrays.AlgoValidateSubsequence(sampleArray, sampleSequence);

            //assert
            Assert.That(result, Is.True);
        }
    }
}
