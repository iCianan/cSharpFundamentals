using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class SameTests
    {
        [Test]
        public void Same_ReturnsTrue_When_SecondArrayContainsSquaredValuesOfFirstArray()
        {
            var sample = new[] { 1, 2, 3 };
            var sampleSquared = new[] { 4, 1, 9 };

            var results = Same.isSame(sample, sampleSquared);

            Assert.That(results, Is.True);
        }

        [Test]
        public void Same_ReturnsTrue_When_SecondArrayContainsSquaredValuesOfFirstArrayRegardlessOfOrder()
        {
            var sample = new[] { 1, 2, 3 };
            var sampleSquared = new[] { 1, 9, 4 };

            var results = Same.isSame(sample, sampleSquared);

            Assert.That(results, Is.True);
        }

        [Test]
        public void Same_ReturnsFalse_When_SecondArrayContainsSquaredValuesOfFirstArrayButIncorrectFrequency()
        {
            var sample = new[] { 1, 2, 1 };
            var sampleSquared = new[] { 4, 4 , 1};

            var results = Same.isSame(sample, sampleSquared);

            Assert.That(results, Is.False);
        }
    }
}
