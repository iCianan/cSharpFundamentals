using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    public class ValidateSubsequence
    {
        [Test]
        public void TestCase1()
        {
            //arrange
            var sampleArray = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sampleSequence = new int[] { 5, 1, 22, 25, 6, -1, 8, 10, 12 };

            //act
            var result = Arrays.ValidateSubsequence(sampleArray, sampleSequence);

            //assert
            Assert.That(result, Is.True);
        }
    }
}
