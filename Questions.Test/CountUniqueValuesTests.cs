using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class CountUniqueValuesTests
    {
        [Test]
        public void CountLinq_Should_ReturnTheNumberOfUniqueValues_When_PassedIntegerArray()
        {
            var testNumbers = new int[] { 1, 1, 1, 1, 2 };

            var results = CountUniqueValues.CountLinq(testNumbers);

            Assert.That(results, Is.EqualTo(2));
        }

        [Test]
        public void CountSet_Should_ReturnTheNumberOfUniqueValues_When_PassedIntegerArray()
        {
            var testNumbers = new int[] { 1, 1, 1, 1, 2 };

            var results = CountUniqueValues.CountSet(testNumbers);

            Assert.That(results, Is.EqualTo(2));
        }

        [Test]
        public void CountPointer_Should_ReturnTheNumberOfUniqueValues_When_PassedSortedIntegerArray()
        {
            var testNumbers = new int[] { 1, 1, 1, 2,3,4,4,7,7,11,21 };

            var results = CountUniqueValues.CountPointer(testNumbers);

            Assert.That(results, Is.EqualTo(7));
        }

        [Test]
        public void CountPointer_Should_ReturnZero_When_PassedEmptyArray()
        {
            var testNumbers = new int[] {  };

            var results = CountUniqueValues.CountPointer(testNumbers);

            Assert.That(results, Is.EqualTo(0));
        }
    }
}
