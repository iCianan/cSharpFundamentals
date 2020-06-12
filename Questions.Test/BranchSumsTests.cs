using NUnit.Framework;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class BranchSumsTests
    {
        [Test]
        public void BranchSum_Should_AddNewNodeToTree_When_GivenAnInteger()
        {
            //arrange
            var BST = new BST(12);
            var sut = new int[] { 4,9,12,8,4,3 };
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            //act
            var results = BranchSum.BranchSums(BST);

            //assert
            Assert.That(results.Count, Is.GreaterThan(1));
        }
    }
}
