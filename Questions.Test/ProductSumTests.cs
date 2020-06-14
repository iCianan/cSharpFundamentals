using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class ProductSumTests
    {
        [Test]
        public void TestCase1()
        {
            var list = new List<object>
            {
                5,
                2,
                new List<object> {7,-1 },
                3,
               new List<object>
               {
                   6,
                   new List<object>{-13,8},
                   4
               }
            };

            var results = ProductSum.ProductSum1(list);

            Assert.That(results, Is.EqualTo(12));
        }
    }
}
