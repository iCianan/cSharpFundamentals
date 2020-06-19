using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class UniqueEmailAddressesTests
    {
        [Test]
        public void NumberOfUniqueEmails_Should_ReturnValidEmailAddressCount_WhenGiveStringArray()
        {
            var input = new[] { "testemail@leetcode.com", "testemail1@leetcode.com", "testemail+david@lee.tcode.com"};

            var results = UniqueEmailAddresses.NumberOfUniqueEmails(input);

            Assert.That(results, Is.EqualTo(2));
        }
    }
}
