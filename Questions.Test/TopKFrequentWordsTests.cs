using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    public class TopKFrequentWordsTests
    {
        [Test]
        public void TestCase1()
        {
            //arrange
            var input = new string[]{ "i", "love", "leetcode", "i", "love", "coding" };
            var k = 2;            

            //act
            var result = TopKFrequentWords.FrequentWords(input, k);

            //assert
            Assert.That(result[0], Is.EqualTo("i"));
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
