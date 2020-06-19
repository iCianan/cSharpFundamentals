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
            int[] first = new int[] { 4, 12, 9, 5, 6,12 };
            int[] second = new int[] { 4,12, 9, 12, 6 };

            var results = FindMissing.Find(first, second);

            Assert.That(results, Is.EqualTo(5));
        }

        [Test]
        public void Find_Set_ReturnMissingNumber_WhenGivenTwoIdenticalArraysWithOneMissingOneNumber()
        {
            int[] first = new int[] { 4, 12, 12, 5, 6 };
            int[] second = new int[] { 4,9,12,6,12 };

            var results = FindMissing.Find_Set(first, second);

            Assert.That(results, Is.EqualTo(5));
        }
    }
}
