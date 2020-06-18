using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class FindMissingTests
    {
        [Test]
        public void FindMissing_ReturnMissingNumber_WhenGivenTwoIdenticalArraysWithOneMissingOneNumber()
        {
            int[] first = new int[] { 4, 5, 5, 9 };
            int[] second = new int[] {  5, 5 ,9 };

            var results = FindMissing.Find(first, second);

            Assert.That(results, Is.EqualTo(4));
        }
    }
}
