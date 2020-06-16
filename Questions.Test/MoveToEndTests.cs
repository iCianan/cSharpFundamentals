using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class MoveToEndTests
    {
        [Test]
        public void MoveElementToEnd_ReturnsArray_SortedByGivenInteger()
        {
            var move = 3;
            var example = new List<int> { 1, 3, 3, 4, 5, 2 };

            var sut = MoveElementToEnd.MoveToEnd(example, move);

            Assert.That(sut[sut.Count - 2], Is.EqualTo(move));
        }
        [Test]
        public void MoveElementToEnd_ReturnsArray_SortedByGivenIntegerFaster()
        {
            var move = 3;
            var example = new List<int> { 1, 3, 3, 4, 5, 2 };

            var sut = MoveElementToEnd.MoveToEndButBetter(example, move);

            Assert.That(sut[sut.Count - 2], Is.EqualTo(move));
        }

    }
}
