using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class GroupAnagramsTests
    {
        [Test]
        public void GroupAnagrams_Returns_ListOfGroupAnagrams()
        {
            var anagrams = new List<string>() { "yo", "act", "flop", "tac", "cat", "oy", "olfp" };

            var results = GroupAnagrams.find(anagrams);

            Assert.That(results.Count, Is.EqualTo(3));
            
        }
            

    }
}
