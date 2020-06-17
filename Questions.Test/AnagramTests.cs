using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class AnagramTests
    {
        [Test]
        public void anagram_Should_ReturnTrue_WhenGivenTwoArraysThatAreAnagramsOfEachOther()
        {
            var string1 = "anagram";
            var string2 = "nagaram";

            var results = anagram.findBetter(string1, string2);

            Assert.That(results, Is.True);
        }

    }
}
